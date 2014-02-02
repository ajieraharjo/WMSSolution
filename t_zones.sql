CREATE TABLE `t_zones` (
  `obj_num` int(11) NOT NULL AUTO_INCREMENT,
  `warehouse_id` varchar(15) NOT NULL,
  `zone_id` varchar(15) NOT NULL,
  `description` varchar(100) NOT NULL,
  `external_id` varchar(45) DEFAULT NULL,
  `active` bit(1) NOT NULL DEFAULT b'1',
  `create_by` varchar(15) NOT NULL,
  `create_time` datetime NOT NULL,
  `update_by` varchar(15) NOT NULL,
  `update_time` datetime NOT NULL,
  PRIMARY KEY (`obj_num`,`warehouse_id`,`zone_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
