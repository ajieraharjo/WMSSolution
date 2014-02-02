DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ins_warehouse`(
warehouse_id varchar(15),
description varchar(100),
external_id varchar(15),
addr_1 varchar(100),
addr_2 varchar(100),
state varchar(100),
city varchar(100),
region varchar(100),
postal_code varchar(100),
country varchar(100),
/*`active,*/
create_by varchar(15)
/*`create_time`,
`update_by`,
`update_time`
*/
)
begin
INSERT INTO `wmsdb`.`t_warehouses`
(
/*`obj_num`,*/
warehouse_id,
description,
external_id,
addr_1,
addr_2,
state,
city,
region,
postal_code,
country,
/*active,*/
create_by,
create_time,
update_by,
update_time)
VALUES
(
/*<{obj_num: }>,*/
warehouse_id,
description,
external_id,
addr_1,
addr_2,
state,
city,
region,
postal_code,
country,
/*'1',*/
create_by,
sysdate(),
create_by,
sysdate()
);
end$$
DELIMITER ;
