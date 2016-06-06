use otc;

#武汉银鹏

#第一笔业务
insert into futures_account_info values (10480233);
insert into client_info value (1, '武汉银鹏投资有限公司', 10480233);

insert into futures_cashflow values (null, 10480233, 148000, 'dp', null, '2015-12-22 10:00:00', null);
insert into client_cashflow values (null, 1, 40000, 'dp', null, '2015-12-22 9:00:00', '');

insert into futures_contracts values ('m1605', 'm', 'abs', 3, 0.05, 2414, 10);
insert into options_contracts values ('OTC_EUP_0M1605-20160121-023900','eu', 'p', 2390, '2016-01-21', 0, 'm1605', 0, 10, 0, 0.28);

#12.23
insert into options_transactions value (1, 1, 'OTC_EUP_0M1605-20160121-023900', 50, 76.44, 2390, '开仓', '买入', '2015-12-23 09:00:00', null, null, null);

insert into futures_transactions value (0, 10480233, 'm1605', 25, 2390, '开仓', '卖出', '2015-12-23 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2397, '平仓', '买入', '2015-12-23 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2398 where contract_code='m1605';
update options_contracts set settle_price=70.79 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.24
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2399, '平仓', '买入', '2015-12-24 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2390, '开仓', '卖出', '2015-12-24 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2378, '开仓', '卖出', '2015-12-24 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2387 where contract_code='m1605';
update options_contracts set settle_price=74.18 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.25
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2377, '开仓', '卖出', '2015-12-25 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2364, '开仓', '卖出', '2015-12-25 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2375 where contract_code='m1605';
update options_contracts set settle_price=78.31 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.28
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2360, '开仓', '卖出', '2015-12-28 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2339, '开仓', '卖出', '2015-12-28 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2354 where contract_code='m1605';
update options_contracts set settle_price=87.77 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.29
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2368, '平仓', '买入', '2015-12-29 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2370, '平仓', '买入', '2015-12-29 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2355 where contract_code='m1605';
update options_contracts set settle_price=85.21 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.30
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2377, '平仓', '买入', '2015-12-30 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2366, '开仓', '卖出', '2015-12-30 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2358, '开仓', '卖出', '2015-12-30 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2363 where contract_code='m1605';
update options_contracts set settle_price=78.65 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#12.31
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2357, '开仓', '卖出', '2015-12-31 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2365, '平仓', '买入', '2015-12-31 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2373, '平仓', '买入', '2015-12-31 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2379, '开仓', '买入', '2015-12-31 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2367 where contract_code='m1605';
update options_contracts set settle_price=74.30 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#1.4
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2368, '平仓', '卖出', '2016-01-04 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2349, '开仓', '卖出', '2016-01-04 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2342, '开仓', '卖出', '2016-01-04 10:25:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2337, '开仓', '卖出', '2016-01-04 10:30:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2323, '开仓', '卖出', '2016-01-04 10:40:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2328, '开仓', '卖出', '2016-01-04 10:50:00', null, null, 1, null);
update futures_contracts set settle_price=2342 where contract_code='m1605';
update options_contracts set settle_price=86.60 where contract_code='OTC_EUP_0M1605-20160121-023900';
call settlement();

#1.5
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2340, '平仓', '买入', '2016-01-05 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 31, 2339, '平仓', '买入', '2016-01-05 10:20:00', null, null, 1, null);
insert into futures_cashflow value(0, 10480233, -12, 'cm', null, null, '手续费调整');

insert into options_transactions value (1, 1, 'OTC_EUP_0M1605-20160121-023900', 50, 87.64, 2337, '平仓', '卖出', '2016-01-05 11:00:00', null, null, null);

#第二笔业务
#1.6
insert into options_contracts values ('OTC_EUP_0M1605-20160204-023320','eu', 'p', 2332, '2016-02-04', 0, 'm1605', 0, 10, 0, 0.245);

insert into options_transactions value (1, 1, 'OTC_EUP_0M1605-20160204-023320', 50, 67.63, 2332, '开仓', '买入', '2016-01-06 11:00:00', null, null, null);

insert into futures_transactions value (0, 10480233, 'm1605', 25, 2332, '开仓', '卖出', '2016-01-06 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2347, '平仓', '买入', '2016-01-06 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2347, '平仓', '买入', '2016-01-06 10:25:00', null, null, 1, null);
update futures_contracts set settle_price=2340 where contract_code='m1605';
update options_contracts set settle_price=59.89 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.7
insert into futures_transactions value (0, 10480233, 'm1605', 2, 2365, '平仓', '买入', '2016-01-07 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 2, 2381, '平仓', '买入', '2016-01-07 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2369 where contract_code='m1605';
update options_contracts set settle_price=47.39 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.8
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2370, '开仓', '卖出', '2016-01-08 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 3, 2397, '平仓', '买入', '2016-01-08 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2403, '平仓', '买入', '2016-01-08 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2391 where contract_code='m1605';
update options_contracts set settle_price=37.72 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.11
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2387, '开仓', '卖出', '2016-01-11 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2386, '开仓', '卖出', '2016-01-11 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2393 where contract_code='m1605';
update options_contracts set settle_price=35.49 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.12
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2393, '平仓', '买入', '2016-01-12 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 2, 2373, '开仓', '卖出', '2016-01-12 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2382 where contract_code='m1605';
update options_contracts set settle_price=37.67 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.13
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2392, '平仓', '买入', '2016-01-13 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2381, '平仓', '买入', '2016-01-13 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2387, '开仓', '卖出', '2016-01-13 10:30:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2410, '平仓', '买入', '2016-01-13 10:40:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2408, '平仓', '买入', '2016-01-13 10:50:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2405, '平仓', '买入', '2016-01-13 11:00:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2390, '开仓', '卖出', '2016-01-13 11:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2383, '开仓', '卖出', '2016-01-13 11:20:00', null, null, 1, null);
update futures_contracts set settle_price=2392 where contract_code='m1605';
update options_contracts set settle_price=32.60 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.14
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2403, '平仓', '买入', '2016-01-14 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2405, '平仓', '买入', '2016-01-14 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2397 where contract_code='m1605';
update options_contracts set settle_price=29.34 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.15
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2406, '平仓', '买入', '2016-01-15 10:10:00', null, null, 1, null);
update futures_contracts set settle_price=2405 where contract_code='m1605';
update options_contracts set settle_price=25.28 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.18
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2423, '平仓', '买入', '2016-01-18 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2438, '平仓', '买入', '2016-01-18 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2443, '平仓', '买入', '2016-01-18 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2453, '平仓', '买入', '2016-01-18 10:20:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2453, '平仓', '买入', '2016-01-18 10:10:00', null, null, 1, null);
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2461, '平仓', '买入', '2016-01-18 10:20:00', null, null, 1, null);
update futures_contracts set settle_price=2433 where contract_code='m1605';
update options_contracts set settle_price=16.72 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.19
insert into futures_transactions value (0, 10480233, 'm1605', 1, 2461, '平仓', '买入', '2016-01-19 10:10:00', null, null, 1, null);
update futures_contracts set settle_price=2461 where contract_code='m1605';
update options_contracts set settle_price=10.29 where contract_code='OTC_EUP_0M1605-20160204-023320';
call settlement();

#1.20
insert into futures_transactions value (0, 10480233, 'm1605', 7, 2450, '平仓', '买入', '2016-01-15 10:10:00', null, null, 1, null);
insert into futures_cashflow value(0, 10480233, -33, 'cm', null, null, '手续费调整');

insert into options_transactions value (1, 1, 'OTC_EUP_0M1605-20160204-023320', 50, 10.05, 2332, '平仓', '卖出', '2016-01-20 11:00:00', null, null, null);


#张勇
#第一笔业务
insert into futures_account_info values (10182233);
insert into client_info value (2, '张勇', 10182233);

insert into futures_cashflow values (null, 10182233, 633000, 'dp', null, '2016-05-05 00:00:00', null);
insert into client_cashflow values (null, 2, 200000, 'dp', null, '2016-05-05 00:00:00', '');

insert into futures_contracts values ('rb1610', 'rb', 'pct', 0.00016, 0.08, 1941, 10);
insert into options_contracts values ('OTC_EUC_RB1610-20160708-024066','eu', 'c', 2406.6, '2016-07-08', 0, 'rb1610', 0, 10, 0, 0.52), ('OTC_EUP_RB1610-20160819-017712','eu', 'p', 1771.2, '2016-08-19', 0, 'rb1610', 0, 10, 0, 0.47);

#5.6
insert into options_transactions value (0, 2, 'OTC_EUC_RB1610-20160708-024066', 60, 152.6472, 2292, '开仓', '买入', '2016-05-06 10:00:00', null, null, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2304, '开仓', '买入', '2016-05-06 10:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2302, '平仓', '卖出', '2016-05-06 10:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 27, 2306, '开仓', '买入', '2016-05-06 10:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2305, '开仓', '买入', '2016-05-06 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2334, '开仓', '买入', '2016-05-06 10:50:00', null, null, 2, null);
update futures_contracts set settle_price=2314 where contract_code='rb1610';
update options_contracts set settle_price=156.97 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.9
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2348, '开仓', '买入', '2016-05-06 21:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2303, '平仓', '卖出', '2016-05-06 21:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2199, '平仓', '卖出', '2016-05-09 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2208, '平仓', '卖出', '2016-05-09 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2181, '平仓', '卖出', '2016-05-09 10:50:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2175, '平仓', '卖出', '2016-05-09 13:50:00', null, null, 2, null);
update futures_contracts set settle_price=2257, margin_rate=0.11 where contract_code='rb1610';
update options_contracts set settle_price=129.43 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.10
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2116, '平仓', '卖出', '2016-05-10 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2109, '开仓', '买入', '2016-05-10 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2098, '平仓', '卖出', '2016-05-10 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2113, '平仓', '卖出', '2016-05-10 10:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2118, '开仓', '买入', '2016-05-10 10:50:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2146, '开仓', '买入', '2016-05-10 13:50:00', null, null, 2, null);
update futures_contracts set settle_price=2124, margin_rate=0.08 where contract_code='rb1610';
update options_contracts set settle_price=78.91 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.11
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2160, '开仓', '买入', '2016-05-11 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2122, '平仓', '卖出', '2016-05-11 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2119, '平仓', '卖出', '2016-05-11 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2146, '开仓', '买入', '2016-05-11 10:40:00', null, null, 2, null);
update futures_contracts set settle_price=2152 where contract_code='rb1610';
update options_contracts set settle_price=85.89 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.12
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2149, '平仓', '卖出', '2016-05-12 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2111, '平仓', '卖出', '2016-05-12 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2077, '平仓', '卖出', '2016-05-12 09:30:00', null, null, 2, null);
update futures_contracts set settle_price=2128 where contract_code='rb1610';
update options_contracts set settle_price=76.31 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.13
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2026, '平仓', '卖出', '2016-05-13 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2003, '平仓', '卖出', '2016-05-13 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2029, '开仓', '买入', '2016-05-13 09:30:00', null, null, 2, null);
update futures_contracts set settle_price=2037 where contract_code='rb1610';
update options_contracts set settle_price=50.09 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.16
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2054, '开仓', '买入', '2016-05-16 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2053 where contract_code='rb1610';
update options_contracts set settle_price=52.20 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.17
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 2114, '开仓', '买入', '2016-05-17 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2076 where contract_code='rb1610';
update options_contracts set settle_price=56.13 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.18
insert into futures_transactions value (0, 10182233, 'rb1610', 3, 2054, '平仓', '卖出', '2016-05-18 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2092 where contract_code='rb1610';
update options_contracts set settle_price=58.43 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.19
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2044, '平仓', '卖出', '2016-05-19 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2047 where contract_code='rb1610';
update options_contracts set settle_price=45.71 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.20
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2063, '开仓', '买入', '2016-05-20 09:10:00', null, null, 2, null);
update futures_contracts set settle_price=2054 where contract_code='rb1610';
update options_contracts set settle_price=45.56 where contract_code='OTC_EUC_RB1610-20160708-024066';
call settlement();

#5.23
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1964, '平仓', '卖出', '2016-05-23 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 13, 1963, '平仓', '卖出', '2016-05-23 09:30:00', null, null, 2, null);

insert into options_transactions value (0, 2, 'OTC_EUC_RB1610-20160708-024066', 60, 22.36, 1965, '平仓', '卖出', '2016-05-23 09:30:00', null, null, 1);
insert into options_transactions value (0, 2, 'OTC_EUP_RB1610-20160819-017712', 80, 91.1184, 1968, '开仓', '买入', '2016-05-23 09:40:00', null, null, 1);

insert into futures_transactions value (0, 10182233, 'rb1610', 22, 1961, '开仓', '卖出', '2016-05-23 09:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 1930, '开仓', '卖出', '2016-05-23 09:50:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1937, '开仓', '卖出', '2016-05-23 09:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1947, '平仓', '买入', '2016-05-23 10:00:00', null, null, 2, null);
update futures_contracts set settle_price=1983 where contract_code='rb1610';
update options_contracts set settle_price=86.70 where contract_code='OTC_EUC_RB1610-20160708-017712';
call settlement();

#5.24
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1954, '平仓', '买入', '2016-05-24 09:40:00', null, null, 2, null);
update futures_contracts set settle_price=1941 where contract_code='rb1610';
update options_contracts set settle_price=97.51 where contract_code='OTC_EUC_RB1610-20160708-017712';
call settlement();

#5.25
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1922, '开仓', '卖出', '2016-05-25 09:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1917, '开仓', '卖出', '2016-05-25 09:40:00', null, null, 2, null);
update futures_contracts set settle_price=1941 where contract_code='rb1610';
update options_contracts set settle_price=96.24 where contract_code='OTC_EUC_RB1610-20160708-017712';
call settlement();

#5.26
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 1951, '平仓', '买入', '2016-05-26 09:40:00', null, null, 2, null);
update futures_contracts set settle_price=1940 where contract_code='rb1610';
update options_contracts set settle_price=95.26 where contract_code='OTC_EUC_RB1610-20160708-017712';
call settlement();

#5.27
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2007, '平仓', '买入', '2016-05-27 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2041, '平仓', '买入', '2016-05-27 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2038, '平仓', '买入', '2016-05-27 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2027, '平仓', '买入', '2016-05-27 09:40:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 2036, '平仓', '买入', '2016-05-27 09:50:00', null, null, 2, null);
update futures_contracts set settle_price=1987 where contract_code='rb1610';
update options_contracts set settle_price=80.69 where contract_code='OTC_EUC_RB1610-20160708-017712';
call settlement();

#5.30
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1951, '开仓', '卖出', '2016-05-30 09:10:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1959, '开仓', '卖出', '2016-05-30 09:20:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1996, '平仓', '买入', '2016-05-30 09:30:00', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 1, 1996, '平仓', '买入', '2016-05-30 09:30:01', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 4, 1996, '平仓', '买入', '2016-05-30 09:30:02', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 12, 1996, '平仓', '买入', '2016-05-30 09:30:03', null, null, 2, null);
insert into futures_transactions value (0, 10182233, 'rb1610', 2, 1996, '平仓', '买入', '2016-05-30 09:30:04', null, null, 2, null);


insert into options_transactions value (0, 2, 'OTC_EUP_RB1610-20160819-017712', 80, 73.82, 1997, '平仓', '卖出', '2016-05-23 09:40:00', null, null, 3);
