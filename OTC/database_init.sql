use otc;
select * from options_contracts;
insert into client_info values (1, '武汉银鹏投资有限公司', 10182233), (2, '张勇', 10182233);
insert into client_cashflow values (1, 2, 200000, 'dp', null, '2016-05-05 00:00:00', '');
insert into options_contracts values ('OTC_EUC_RB1610-20160708-024066','eu', 'c', 2406.6, '2016-07-08', 0, 'rb1610', 0, 10, 0, 0.52), ('OTC_EUP_RB1610-20160819-017712','eu', 'p', 1771.2, '2016-08-19', 0, 'rb1610', 0, 10, 0, 0.47);

#5.6
insert into options_transactions value (1, 2, 'OTC_EUC_RB1610-20160708-024066', 60, 152.6472, 2292, '开仓', '买入', '2016-05-06 10:00:00', null, null, null);

insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2306, '开仓', '买入', '2016-05-06 10:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2304, '平仓', '卖出', '2016-05-06 10:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 27, 2306, '开仓', '买入', '2016-05-06 10:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2305, '开仓', '买入', '2016-05-06 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2334, '开仓', '买入', '2016-05-06 10:50:00', null, null, 2, null);
update futures_contracts set settle_price=2314;
update options_contracts set settle_price=156.97;
call settlement();

#5.9
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2348, '开仓', '买入', '2016-05-06 21:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2303, '平仓', '卖出', '2016-05-06 21:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2199, '平仓', '卖出', '2016-05-09 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2208, '平仓', '卖出', '2016-05-09 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2181, '平仓', '卖出', '2016-05-09 10:50:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2175, '平仓', '卖出', '2016-05-09 13:50:00', null, null, 2, null);
update futures_contracts set settle_price=2257, margin_rate=0.11;
update options_contracts set settle_price=129.43;
call settlement();

#5.10
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2116, '平仓', '卖出', '2016-05-10 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2109, '开仓', '买入', '2016-05-10 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2098, '平仓', '卖出', '2016-05-10 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2113, '平仓', '卖出', '2016-05-10 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2118, '开仓', '买入', '2016-05-10 10:50:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2146, '开仓', '买入', '2016-05-10 13:50:00', null, null, 2, null);
update futures_contracts set settle_price=2124, margin_rate=0.08;
update options_contracts set settle_price=78.91;
call settlement();

#5.11
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2160, '开仓', '买入', '2016-05-11 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2122, '平仓', '卖出', '2016-05-11 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2119, '平仓', '卖出', '2016-05-11 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2146, '开仓', '买入', '2016-05-11 10:40:00', null, null, 2, null);
update futures_contracts set settle_price=2152;
update options_contracts set settle_price=85.89;
call settlement();

#5.12
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2149, '平仓', '卖出', '2016-05-12 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2111, '平仓', '卖出', '2016-05-12 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2077, '平仓', '卖出', '2016-05-12 09:30:00', null, null, 2, null);
update futures_contracts set settle_price=2128;
update options_contracts set settle_price=76.31;
call settlement();

#5.13
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2026, '平仓', '卖出', '2016-05-13 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2003, '平仓', '卖出', '2016-05-13 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2029, '开仓', '买入', '2016-05-13 09:30:00', null, null, 2, null);
update futures_contracts set settle_price=2037;
update options_contracts set settle_price=50.09;
call settlement();

#5.16
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2054, '开仓', '买入', '2016-05-16 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2053;
update options_contracts set settle_price=52.20;
call settlement();

#5.17
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2114, '开仓', '买入', '2016-05-17 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2076;
update options_contracts set settle_price=56.13;
call settlement();

#5.18
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2054, '平仓', '卖出', '2016-05-18 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2092;
update options_contracts set settle_price=58.43;
call settlement();

#5.19
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2044, '平仓', '卖出', '2016-05-19 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2047;
update options_contracts set settle_price=45.71;
call settlement();

#5.20
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2063, '开仓', '买入', '2016-05-20 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2054;
update options_contracts set settle_price=45.56;
call settlement();

#5.23
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2064, '平仓', '卖出', '2016-05-23 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 13, 2063, '平仓', '卖出', '2016-05-23 09:30:00', null, null, 2, null);

insert into options_transactions value (0, 2, 'OTC_EUC_RB1610-20160708-024066', 60, 22.36, 1965, '平仓', '卖出', '2016-05-23 09:30:00', null, null, 1);

select * from options_contracts;