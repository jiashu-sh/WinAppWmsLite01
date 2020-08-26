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

 Date: 18/08/2020 14:30:18
*/


-- ----------------------------
-- Table structure for im_item_barcode
-- ----------------------------
DROP TABLE IF EXISTS "public"."im_item_barcode";
CREATE TABLE "public"."im_item_barcode" (
  "im_item_barcode_id" int4 NOT NULL DEFAULT nextval('im_item_barcode_id_seq'::regclass),
  "product_no" int4 NOT NULL,
  "customer_id" int4 NOT NULL,
  "item_barcode" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Indexes structure for table im_item_barcode
-- ----------------------------
CREATE INDEX "ix_product_no" ON "public"."im_item_barcode" USING btree (
  "product_no" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Uniques structure for table im_item_barcode
-- ----------------------------
ALTER TABLE "public"."im_item_barcode" ADD CONSTRAINT "uk_barcode_custid" UNIQUE ("customer_id", "item_barcode");

-- ----------------------------
-- Primary Key structure for table im_item_barcode
-- ----------------------------
ALTER TABLE "public"."im_item_barcode" ADD CONSTRAINT "im_item_barcode_pkey" PRIMARY KEY ("im_item_barcode_id");
