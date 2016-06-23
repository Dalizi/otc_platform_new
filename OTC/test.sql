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
    
select * from future_position_settle_info;