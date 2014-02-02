DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ins_area`(
warehouse_id varchar(15),
area_id varchar(15),
description varchar(100),
external_id varchar(15),
access_type varchar(15),
/*`active,*/
create_by varchar(15)
/*`create_time`,
`update_by`,
`update_time`
*/
)
begin
INSERT INTO `wmsdb`.`t_areas`
(
/*`obj_num`,*/
warehouse_id,
area_id,
description,
external_id,
access_type,
/*active,*/
create_by,
create_time,
update_by,
update_time)
VALUES
(
/*<{obj_num: }>,*/
warehouse_id,
area_id,
description,
external_id,
access_type,
/*'1',*/
create_by,
sysdate(),
create_by,
sysdate()
);
end$$
DELIMITER ;
