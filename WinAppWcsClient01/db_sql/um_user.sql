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

 Date: 18/08/2020 14:32:20
*/


-- ----------------------------
-- Table structure for um_user
-- ----------------------------
DROP TABLE IF EXISTS "public"."um_user";
CREATE TABLE "public"."um_user" (
  "um_user_id" int4 NOT NULL DEFAULT nextval('um_user_id_seq'::regclass),
  "user_id" int4 NOT NULL,
  "login_name" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "login_pwd" varchar(50) COLLATE "pg_catalog"."default",
  "user_dep_id" int4,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6) DEFAULT ('now'::text)::date,
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table um_user
-- ----------------------------
ALTER TABLE "public"."um_user" ADD CONSTRAINT "um_user_pkey" PRIMARY KEY ("um_user_id");
