using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Shared;

namespace BlazorApp1.Server.Models;

public partial class PlanActualContext : DbContext
{
    public PlanActualContext()
    {
    }

    public PlanActualContext(DbContextOptions<PlanActualContext> options)
        : base(options)
    {
    }


    public virtual DbSet<EappLookupEntry> EappLookupEntries { get; set; }

    public virtual DbSet<EappUser> EappUsers { get; set; }

    public virtual DbSet<InvFgPickHeader> InvFgPickHeaders { get; set; }

    public virtual DbSet<InvFgPickLine> InvFgPickLines { get; set; }

    public virtual DbSet<InvItemMaster> InvItemMasters { get; set; }

    public virtual DbSet<InvPickRequest> InvPickRequests { get; set; }

    public virtual DbSet<PlanActual> PlanActuals { get; set; }

    public virtual DbSet<PlanactualTemp> PlanactualTemps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=Plan_Actual;Username=postgres;Password=guswhd23");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EappLookupEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("eapp_lookup_entry_pkey");

            entity.ToTable("eapp_lookup_entry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntryCode)
                .HasColumnType("character varying")
                .HasColumnName("entry_code");
            entity.Property(e => e.EntryDescription)
                .HasColumnType("character varying")
                .HasColumnName("entry_description");
            entity.Property(e => e.LookupTypeId).HasColumnName("lookup_type_id");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
        });

        modelBuilder.Entity<EappUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eapp_user");

            entity.Property(e => e.EnableFlag)
                .HasColumnType("character varying")
                .HasColumnName("enable_flag");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.UserGroup).HasColumnName("user_group");
            entity.Property(e => e.UserGroupName)
                .HasColumnType("character varying")
                .HasColumnName("user_group_name");
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasColumnType("character varying")
                .HasColumnName("user_name");
            entity.Property(e => e.UserNo)
                .HasColumnType("character varying")
                .HasColumnName("user_no");
        });

        modelBuilder.Entity<InvFgPickHeader>(entity =>
        {
            entity.HasKey(e => e.PickHeaderId).HasName("INV_FG_PICK_HEADER_pkey");

            entity.ToTable("INV_FG_PICK_HEADER");

            entity.Property(e => e.PickHeaderId)
                .ValueGeneratedNever()
                .HasColumnName("PICK_HEADER_ID");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.PickDate).HasColumnName("PICK_DATE");
            entity.Property(e => e.ShipToCustSiteId).HasColumnName("SHIP_TO_CUST_SITE_ID");
            entity.Property(e => e.SobId).HasColumnName("SOB_ID");
        });

        modelBuilder.Entity<InvFgPickLine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INV_FG_PICK_LINE");

            entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.PickHeaderId).HasColumnName("PICK_HEADER_ID");
            entity.Property(e => e.PickLineId).HasColumnName("PICK_LINE_ID");
            entity.Property(e => e.PickQty).HasColumnName("PICK_QTY");
            entity.Property(e => e.SobId).HasColumnName("SOB_ID");
        });

        modelBuilder.Entity<InvItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INV_ITEM_MASTER");

            entity.Property(e => e.CustomerSiteId).HasColumnName("CUSTOMER_SITE_ID");
            entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");
            entity.Property(e => e.ItemCategoryCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_CATEGORY_CODE");
            entity.Property(e => e.ItemCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_CODE");
            entity.Property(e => e.ItemDescription)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_DESCRIPTION");
            entity.Property(e => e.ItemDivisionCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_DIVISION_CODE");
            entity.Property(e => e.ItemSectionCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_SECTION_CODE");
            entity.Property(e => e.OrgId).HasColumnName("ORG_ID");
            entity.Property(e => e.SobId).HasColumnName("SOB_ID");
        });

        modelBuilder.Entity<InvPickRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INV_PICK_REQUEST");

            entity.Property(e => e.CustSiteCode).HasColumnName("CUST_SITE_CODE");
            entity.Property(e => e.DeliveryQty).HasColumnName("DELIVERY_QTY");
            entity.Property(e => e.ExtendDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("EXTEND_DATE");
            entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");
            entity.Property(e => e.ItemCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_CODE");
            entity.Property(e => e.ItemDescription)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_DESCRIPTION");
            entity.Property(e => e.OrderNo)
                .HasColumnType("character varying")
                .HasColumnName("ORDER_NO");
            entity.Property(e => e.OrderTypeDesc)
                .HasColumnType("character varying")
                .HasColumnName("ORDER_TYPE_DESC");
            entity.Property(e => e.PickFlag)
                .HasColumnType("character varying")
                .HasColumnName("pick_flag");
            entity.Property(e => e.SalesOrderQty).HasColumnName("SALES_ORDER_QTY");
        });

        modelBuilder.Entity<PlanActual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PLAN_ACTUAL_pkey");

            entity.ToTable("PLAN_ACTUAL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustSiteId).HasColumnName("CUST_SITE_ID");
            entity.Property(e => e.InventoryItemId).HasColumnName("INVENTORY_ITEM_ID");
            entity.Property(e => e.ItemCode)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_CODE");
            entity.Property(e => e.ItemDate).HasColumnName("ITEM_DATE");
            entity.Property(e => e.ItemDescription)
                .HasColumnType("character varying")
                .HasColumnName("ITEM_DESCRIPTION");
            entity.Property(e => e.ItemQty).HasColumnName("ITEM_QTY");
            entity.Property(e => e.SalesFcstDivisionCode)
                .HasColumnType("character varying")
                .HasColumnName("SALES_FCST_DIVISION_CODE");
            entity.Property(e => e.SortType)
                .HasColumnType("character varying")
                .HasColumnName("SORT_TYPE");
        });

        modelBuilder.Entity<PlanactualTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("planactual_temp_pkey");

            entity.ToTable("planactual_temp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustSiteId).HasColumnName("cust_site_id");
            entity.Property(e => e.EntryDescription)
                .HasColumnType("character varying")
                .HasColumnName("entry_description");
            entity.Property(e => e.InventoryItemId).HasColumnName("inventory_item_id");
            entity.Property(e => e.ItemCode)
                .HasColumnType("character varying")
                .HasColumnName("item_code");
            entity.Property(e => e.ItemDate).HasColumnName("item_date");
            entity.Property(e => e.ItemDescription)
                .HasColumnType("character varying")
                .HasColumnName("item_description");
            entity.Property(e => e.Qty01).HasColumnName("qty_01");
            entity.Property(e => e.Qty02).HasColumnName("qty_02");
            entity.Property(e => e.Qty03).HasColumnName("qty_03");
            entity.Property(e => e.Qty04).HasColumnName("qty_04");
            entity.Property(e => e.Qty05).HasColumnName("qty_05");
            entity.Property(e => e.Qty06).HasColumnName("qty_06");
            entity.Property(e => e.Qty07).HasColumnName("qty_07");
            entity.Property(e => e.Qty08).HasColumnName("qty_08");
            entity.Property(e => e.Qty09).HasColumnName("qty_09");
            entity.Property(e => e.Qty10).HasColumnName("qty_10");
            entity.Property(e => e.Qty11).HasColumnName("qty_11");
            entity.Property(e => e.Qty12).HasColumnName("qty_12");
            entity.Property(e => e.Qty13).HasColumnName("qty_13");
            entity.Property(e => e.Qty14).HasColumnName("qty_14");
            entity.Property(e => e.Qty15).HasColumnName("qty_15");
            entity.Property(e => e.Qty16).HasColumnName("qty_16");
            entity.Property(e => e.Qty17).HasColumnName("qty_17");
            entity.Property(e => e.Qty18).HasColumnName("qty_18");
            entity.Property(e => e.Qty19).HasColumnName("qty_19");
            entity.Property(e => e.Qty20).HasColumnName("qty_20");
            entity.Property(e => e.Qty21).HasColumnName("qty_21");
            entity.Property(e => e.Qty22).HasColumnName("qty_22");
            entity.Property(e => e.Qty23).HasColumnName("qty_23");
            entity.Property(e => e.Qty24).HasColumnName("qty_24");
            entity.Property(e => e.Qty25).HasColumnName("qty_25");
            entity.Property(e => e.Qty26).HasColumnName("qty_26");
            entity.Property(e => e.Qty27).HasColumnName("qty_27");
            entity.Property(e => e.Qty28).HasColumnName("qty_28");
            entity.Property(e => e.Qty29).HasColumnName("qty_29");
            entity.Property(e => e.Qty30).HasColumnName("qty_30");
            entity.Property(e => e.Qty31).HasColumnName("qty_31");
            entity.Property(e => e.Qty32).HasColumnName("qty_32");
            entity.Property(e => e.Qty33).HasColumnName("qty_33");
            entity.Property(e => e.Qty34).HasColumnName("qty_34");
            entity.Property(e => e.Qty35).HasColumnName("qty_35");
            entity.Property(e => e.Qty36).HasColumnName("qty_36");
            entity.Property(e => e.Qty37).HasColumnName("qty_37");
            entity.Property(e => e.Qty38).HasColumnName("qty_38");
            entity.Property(e => e.Qty39).HasColumnName("qty_39");
            entity.Property(e => e.Qty40).HasColumnName("qty_40");
            entity.Property(e => e.Qty41).HasColumnName("qty_41");
            entity.Property(e => e.Qty42).HasColumnName("qty_42");
            entity.Property(e => e.Qty43).HasColumnName("qty_43");
            entity.Property(e => e.Qty44).HasColumnName("qty_44");
            entity.Property(e => e.Qty45).HasColumnName("qty_45");
            entity.Property(e => e.Qty46).HasColumnName("qty_46");
            entity.Property(e => e.Qty47).HasColumnName("qty_47");
            entity.Property(e => e.Qty48).HasColumnName("qty_48");
            entity.Property(e => e.Qty49).HasColumnName("qty_49");
            entity.Property(e => e.Qty50).HasColumnName("qty_50");
            entity.Property(e => e.Qty51).HasColumnName("qty_51");
            entity.Property(e => e.Qty52).HasColumnName("qty_52");
            entity.Property(e => e.QtyTotal).HasColumnName("qty_total");
            entity.Property(e => e.SortType)
                .HasColumnType("character varying")
                .HasColumnName("sort_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
