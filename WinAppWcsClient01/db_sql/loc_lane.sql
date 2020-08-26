/*
 Navicat Premium Data Transfer

 Source Server         : 127.0.0.1
 Source Server Type    : PostgreSQL
 Source Server Version : 90617
 Source Host           : 127.0.0.1:5432
 Source Catalog        : wcs_db_01
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90617
 File Encoding         : 65001

 Date: 18/08/2020 14:31:26
*/


-- ----------------------------
-- Table structure for loc_lane
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_lane";
CREATE TABLE "public"."loc_lane" (
  "loc_lane_id" int4 NOT NULL DEFAULT nextval('loc_lane_id_seq'::regclass),
  "lane_no" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "lane_desc" varchar(50) COLLATE "pg_catalog"."default",
  "area_no" varchar(5) COLLATE "pg_catalog"."default" NOT NULL,
  "lane_pri" int4 DEFAULT 0,
  "layers_set" int4 DEFAULT 0,
  "x_point" int4 DEFAULT 0,
  "y_point" int4 DEFAULT 0,
  "lane_direction" varchar(1) COLLATE "pg_catalog"."default",
  "lane_order" varchar(3) COLLATE "pg_catalog"."default",
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_lane
-- ----------------------------
ALTER TABLE "public"."loc_lane" ADD CONSTRAINT "loc_lane_pkey" PRIMARY KEY ("loc_lane_id");
