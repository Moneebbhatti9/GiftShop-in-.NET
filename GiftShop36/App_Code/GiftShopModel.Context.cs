﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class GiftShopEntities : DbContext
{
    public GiftShopEntities()
        : base("name=GiftShopEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<AddToCartTable> AddToCartTables { get; set; }
    public virtual DbSet<BrandTable> BrandTables { get; set; }
    public virtual DbSet<CategoryTable> CategoryTables { get; set; }
    public virtual DbSet<MainOrderTable> MainOrderTables { get; set; }
    public virtual DbSet<OrderDetailTable> OrderDetailTables { get; set; }
    public virtual DbSet<ProductTable> ProductTables { get; set; }
    public virtual DbSet<userTable> userTables { get; set; }

    public virtual ObjectResult<AddBrand_Result> AddBrand()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddBrand_Result>("AddBrand");
    }

    public virtual ObjectResult<AddCategory_Result> AddCategory()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddCategory_Result>("AddCategory");
    }

    public virtual int deleteBrand(Nullable<int> brandId)
    {
        var brandIdParameter = brandId.HasValue ?
            new ObjectParameter("brandId", brandId) :
            new ObjectParameter("brandId", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteBrand", brandIdParameter);
    }

    public virtual int deleteCategory(Nullable<int> categoryId)
    {
        var categoryIdParameter = categoryId.HasValue ?
            new ObjectParameter("CategoryId", categoryId) :
            new ObjectParameter("CategoryId", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCategory", categoryIdParameter);
    }

    public virtual int deleteProduct(Nullable<int> prdID)
    {
        var prdIDParameter = prdID.HasValue ?
            new ObjectParameter("prdID", prdID) :
            new ObjectParameter("prdID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteProduct", prdIDParameter);
    }

    public virtual int deleteProductFromCart(Nullable<int> productId)
    {
        var productIdParameter = productId.HasValue ?
            new ObjectParameter("productId", productId) :
            new ObjectParameter("productId", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteProductFromCart", productIdParameter);
    }

    public virtual int DeleteUsers(Nullable<int> userID)
    {
        var userIDParameter = userID.HasValue ?
            new ObjectParameter("userID", userID) :
            new ObjectParameter("userID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUsers", userIDParameter);
    }

    public virtual ObjectResult<DoLogin_Result> DoLogin(string email, string password)
    {
        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoLogin_Result>("DoLogin", emailParameter, passwordParameter);
    }

    public virtual ObjectResult<string> EmailExist(string email)
    {
        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EmailExist", emailParameter);
    }

    public virtual ObjectResult<FilterProductbyBrand_Result> FilterProductbyBrand(string brandName)
    {
        var brandNameParameter = brandName != null ?
            new ObjectParameter("BrandName", brandName) :
            new ObjectParameter("BrandName", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FilterProductbyBrand_Result>("FilterProductbyBrand", brandNameParameter);
    }

    public virtual ObjectResult<getBrand_Result> getBrand()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getBrand_Result>("getBrand");
    }

    public virtual ObjectResult<getCartProduct_Result> getCartProduct(string uniqueKey)
    {
        var uniqueKeyParameter = uniqueKey != null ?
            new ObjectParameter("uniqueKey", uniqueKey) :
            new ObjectParameter("uniqueKey", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCartProduct_Result>("getCartProduct", uniqueKeyParameter);
    }

    public virtual ObjectResult<getCategory_Result> getCategory()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCategory_Result>("getCategory");
    }

    public virtual ObjectResult<getProductList_Result> getProductList()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getProductList_Result>("getProductList");
    }

    public virtual ObjectResult<getUsers_Result> getUsers()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUsers_Result>("getUsers");
    }

    public virtual ObjectResult<Productfilter_Result> Productfilter(Nullable<int> brandID)
    {
        var brandIDParameter = brandID.HasValue ?
            new ObjectParameter("BrandID", brandID) :
            new ObjectParameter("BrandID", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Productfilter_Result>("Productfilter", brandIDParameter);
    }
}
