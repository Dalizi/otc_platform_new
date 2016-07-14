ALTER TABLE futures_contracts add column volatility double;
INSERT INTO futures_contracts VALUES ('m1612', 'm', 'abs', 1.2, 0.05, 2390, 10, 0.4);
UPDATE futures_contracts SET volatility=0.4 WHERE contract_code='m1609';
SELECT * FROM futures_contracts;

use otc_test;
SELECT contract_code, SUM(IF(long_short='买入',quantity, 0)) as long_quantity,  SUM(IF(long_short='卖出',quantity, 0)) as short_quantity, SUM(cashflow_value)
FROM futures_transactions ft, futures_cashflow fc
WHERE ft.transaction_time>=concat(DATE_SUB('2016-01-06',interval 1 day), ' 21:00:00') AND ft.transaction_time<CONCAT('2016-01-06', ' 21:00:00') AND fc.cashflow_type='cm' AND fc.transaction_id=ft.transaction_id
AND fc.time_stamp>=concat(DATE_SUB('2016-01-06',interval 1 day), ' 21:00:00') AND fC.time_stamp<CONCAT('2016-01-06', ' 21:00:00')
GROUP BY contract_code;
select * from futures_transactions ft WHERE ft.transaction_time>=concat(DATE_SUB('2016-01-06',interval 1 day), ' 21:00:00') AND ft.transaction_time<CONCAT('2016-01-06', ' 21:00:00');
SELECT 'm1609' REGEXP '[0-9]{5}';
SELECT SUBSTRING('m1609', length('m1609')-3, length('m1609'));

insert INTO future_position_settle_info
(SELECT
		CONCAT(category_name,'期货'), 
        pos_info.underlying_code, 
        pos_info.contract_code,
        '---',
        IF(pos_info.underlying_code REGEXP '[0-9]{4}', SUBSTRING(pos_info.underlying_code, LENGTH(pos_info.underlying_code)-3, LENGTH(pos_info.underlying_code)), 
			SUBSTRING(pos_info.underlying_code,LENGTH(pos_info.underlying_code)-2, LENGTH(pos_info.underlying_code))),
		'---',
        trans_info.long_quantity,
        trans_info.short_quantity,
        pos_info.quantity,
        pos_info.daily_pnl,
        0,
        0,
        0,
        0,
        0,
        '---',
        pos_info.settle_price,
        '---',
        '---',
        '---',
        trans_info.commission,
        pos_info.daily_pnl-trans_info.commission
    FROM (
		SELECT category_name, fc.underlying_code as underlying_code, fvp.contract_code as contract_code, 
        fc.underlying_code as commodity_code, fvp.quantity as quantity, fc.settle_price as settle_price, daily_pnl
        FROM futures_verbose_positions fvp, futures_contracts fc, commodity_category cc
        WHERE fvp.contract_code=fc.contract_code AND fc.underlying_code=cc.category_code
		) pos_info,
        (
        SELECT contract_code, SUM(IF(long_short='买入',quantity, 0)) as long_quantity,  SUM(IF(long_short='卖出',quantity, 0)) as short_quantity, SUM(cashflow_value) as commission
		FROM futures_transactions ft, futures_cashflow fc
		WHERE ft.transaction_time>=concat(DATE_SUB('2016-01-06',interval 1 day), ' 21:00:00') AND ft.transaction_time<CONCAT('2016-01-06', ' 21:00:00') AND fc.cashflow_type='cm' AND fc.transaction_id=ft.transaction_id
		AND fc.time_stamp>=concat(DATE_SUB('2016-01-06',interval 1 day), ' 21:00:00') AND fC.time_stamp<CONCAT('2016-01-06', ' 21:00:00')
		GROUP BY contract_code
        ) trans_info )
    ;
    
select * from future_position_settle_info where settle_date='2016-01-04';
select * from futures_transactions where Date(transaction_time) = '2016-01-05';

SELECT
		category_name, 
        pos_info.underlying_code, 
        pos_info.contract_code,
        CONCAT(options_type_name, IF(type_direction='c', '看涨', '看跌')),
        IF(pos_info.underlying_code REGEXP '[0-9]{4}', SUBSTRING(pos_info.underlying_code, LENGTH(pos_info.underlying_code)-3, LENGTH(pos_info.underlying_code)),  SUBSTRING(pos_info.underlying_code,LENGTH(pos_info.underlying_code)-2, LENGTH(pos_info.underlying_code))),
		strike_price,
        IFNULL(trans_info.short_open_quantity,0),
        IFNULL(trans_info.short_close_quantity,0),
        IFNULL(trans_info.long_open_quantity,0),
        IFNULL(trans_info.long_close_quantity,0),
        SUM(IF(pos_info.long_short='卖出',pos_info.quantity, 0)),
        SUM(IF(pos_info.long_short='买入',pos_info.quantity, 0)),
        SUM(pos_info.daily_close_pnl),
        SUM(pos_info.daily_settle_pnl),
        0,
        0,
        0,
        0,
        0,
        null,
        pos_info.settle_price,
        volatility,
        init_value,
        curr_value,
        IFNULL(trans_info.commission,0),
        SUM(pos_info.daily_close_pnl+pos_info.daily_settle_pnl)-IFNULL(trans_info.commission,0),
		'2016-01-05',
        holding_price,
        inbalance_premium,
        pos_info.my_id
    FROM (
		SELECT category_name, oc.underlying_code as underlying_code, ovp.contract_code as contract_code, oc.type_direction, ot.options_type_name, strike_price, oc.volatility, ovp.long_short,
        ovp.open_price*quantity*oc.multiplier as init_value, oc.settle_price*quantity*oc.multiplier as curr_value,  ovp.holding_price, ovp.inbalance_premium,
        fc.underlying_code as commodity_code, ovp.quantity as quantity, oc.settle_price as settle_price, daily_close_pnl, daily_settle_pnl, CONCAT(ovp.client_id, '-', ovp.transaction_id) as my_id
        FROM options_verbose_positions ovp, options_contracts oc, futures_contracts fc, commodity_category cc, options_types ot
        WHERE ovp.contract_code=oc.contract_code AND oc.underlying_code=fc.contract_code AND fc.underlying_code=cc.category_code AND oc.type_code=ot.options_type_code
		) pos_info 
        LEFT JOIN
        (
        SELECT contract_code, 
        SUM(IF(long_short='买入' and open_close='开仓',quantity, 0)) as long_open_quantity,
        SUM(IF(long_short='买入' and open_close='平仓',quantity, 0)) as long_close_quantity,
        SUM(IF(long_short='卖出' and open_close='开仓',quantity, 0)) as short_open_quantity, 
        SUM(IF(long_short='卖出' and open_close='平仓',quantity, 0)) as short_close_quantity, 
        SUM(cashflow_value) as commission,
        CONCAT(ot.client_id, '-', ot.transaction_id) as my_id
		FROM options_transactions ot, client_cashflow cc
		WHERE ot.transaction_time>=concat(DATE_SUB('2016-01-05',interval 1 day), ' 21:00:00') AND ot.transaction_time<CONCAT('2016-01-05', ' 21:00:00') AND cc.cashflow_type='cm' AND (cc.transaction_id=ot.transaction_id OR cc.transaction_id is null) AND cc.client_id=ot.client_id
		AND cc.time_stamp>=concat(DATE_SUB('2016-01-05',interval 1 day), ' 21:00:00') AND cc.time_stamp<CONCAT('2016-01-05', ' 21:00:00')
		GROUP BY my_id
        ) trans_info
        ON pos_info.my_id=trans_info.my_id
        GROUP BY pos_info.my_id;
    
    SELECT
		category_name, 
        pos_info.underlying_code, 
        pos_info.contract_code,
        null,
        IF(pos_info.contract_code REGEXP '[0-9]{4}', SUBSTRING(pos_info.contract_code, LENGTH(pos_info.contract_code)-3, LENGTH(pos_info.contract_code)),  SUBSTRING(pos_info.contract_code,LENGTH(pos_info.contract_code)-2, LENGTH(pos_info.contract_code))),
		null,
        IFNULL(trans_info.long_open_quantity,0),
        IFNULL(trans_info.long_close_quantity,0),
        IFNULL(trans_info.short_open_quantity,0),
        IFNULL(trans_info.short_close_quantity,0),
        SUM(IF(pos_info.long_short='买入',pos_info.quantity, 0)),
        SUM(IF(pos_info.long_short='卖出',pos_info.quantity, 0)),
        SUM(pos_info.daily_close_pnl),
        SUM(pos_info.daily_settle_pnl),
        SUM(IF(pos_info.long_short='买入',pos_info.quantity, - pos_info.quantity)),
        0,
        0,
        0,
        0,
        null,
        pos_info.settle_price,
        null,
        null,
        null,
        IFNULL(trans_info.commission,0),
        SUM(pos_info.daily_close_pnl+pos_info.daily_settle_pnl)-IFNULL(trans_info.commission,0),
        SUM(occupied_margin),
        '2016-01-05',
        holding_price
    FROM (
		SELECT category_name, fc.underlying_code as underlying_code, fvp.contract_code as contract_code, fvp.long_short, fvp.occupied_margin,
        fc.underlying_code as commodity_code, fvp.quantity as quantity, fc.settle_price as settle_price, daily_close_pnl, daily_settle_pnl, fvp.holding_price
        FROM futures_verbose_positions fvp, futures_contracts fc, commodity_category cc
        WHERE fvp.contract_code=fc.contract_code AND fc.underlying_code=cc.category_code
		) pos_info
        LEFT JOIN
        (
        SELECT contract_code, 
        SUM(IF(long_short='买入' and open_close='开仓',quantity, 0)) as long_open_quantity,
        SUM(IF(long_short='买入' and open_close='平仓',quantity, 0)) as long_close_quantity,
        SUM(IF(long_short='卖出' and open_close='开仓',quantity, 0)) as short_open_quantity, 
        SUM(IF(long_short='卖出' and open_close='平仓',quantity, 0)) as short_close_quantity, 
        SUM(cashflow_value) as commission
		FROM futures_transactions ft, futures_cashflow fc
		WHERE ft.transaction_time>=concat(DATE_SUB('2016-01-05',interval 1 day), ' 21:00:00') AND ft.transaction_time<CONCAT('2016-01-05', ' 21:00:00') 
        AND fc.cashflow_type='cm' AND (fc.transaction_id=ft.transaction_id OR fc.transaction_id is null) AND fc.account_no=ft.account_no
		AND fc.time_stamp>=concat(DATE_SUB('2016-01-05',interval 1 day), ' 21:00:00') AND fc.time_stamp<CONCAT('2016-01-05', ' 21:00:00')
		GROUP BY contract_code
        ) trans_info
        ON pos_info.contract_code=trans_info.contract_code
        GROUP BY contract_code
        
    ;