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

 Date: 18/08/2020 14:31:43
*/


-- ----------------------------
-- Table structure for loc_location_hold
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_location_hold";
CREATE TABLE "public"."loc_location_hold" (
  "loc_location_hold_id" int4 NOT NULL DEFAULT nextval('loc_location_hold_id_seq'::regclass),
  "location_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "hold_time" timestamptz(6),
  "hold_uid" int4,
  "release_time" timestamptz(6),
  "release_uid" int4,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_location_hold
-- ----------------------------
ALTER TABLE "public"."loc_location_hold" ADD CONSTRAINT "loc_location_hold_pkey" PRIMARY KEY ("loc_location_hold_id");
