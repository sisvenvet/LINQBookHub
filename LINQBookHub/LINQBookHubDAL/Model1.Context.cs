﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWCFServices.LINQBookHubDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ASPNETEntities : DbContext
    {
        public ASPNETEntities()
            : base("name=ASPNETEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<stock_detail> stock_detail { get; set; }
        public virtual DbSet<stock_master> stock_master { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tr_header> tr_header { get; set; }
    
        public virtual ObjectResult<Nullable<int>> p_stock_masters(Nullable<int> code_value, string code_display, Nullable<decimal> rate, string uom, Nullable<decimal> opening, Nullable<decimal> closing)
        {
            var code_valueParameter = code_value.HasValue ?
                new ObjectParameter("code_value", code_value) :
                new ObjectParameter("code_value", typeof(int));
    
            var code_displayParameter = code_display != null ?
                new ObjectParameter("code_display", code_display) :
                new ObjectParameter("code_display", typeof(string));
    
            var rateParameter = rate.HasValue ?
                new ObjectParameter("rate", rate) :
                new ObjectParameter("rate", typeof(decimal));
    
            var uomParameter = uom != null ?
                new ObjectParameter("uom", uom) :
                new ObjectParameter("uom", typeof(string));
    
            var openingParameter = opening.HasValue ?
                new ObjectParameter("opening", opening) :
                new ObjectParameter("opening", typeof(decimal));
    
            var closingParameter = closing.HasValue ?
                new ObjectParameter("closing", closing) :
                new ObjectParameter("closing", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("p_stock_masters", code_valueParameter, code_displayParameter, rateParameter, uomParameter, openingParameter, closingParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> p_stock_trans(Nullable<System.DateTime> date, string @ref, Nullable<decimal> qty_in, Nullable<decimal> qty_out, string id, Nullable<int> doc_no, string narr, Nullable<int> code_value)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var refParameter = @ref != null ?
                new ObjectParameter("ref", @ref) :
                new ObjectParameter("ref", typeof(string));
    
            var qty_inParameter = qty_in.HasValue ?
                new ObjectParameter("qty_in", qty_in) :
                new ObjectParameter("qty_in", typeof(decimal));
    
            var qty_outParameter = qty_out.HasValue ?
                new ObjectParameter("qty_out", qty_out) :
                new ObjectParameter("qty_out", typeof(decimal));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var doc_noParameter = doc_no.HasValue ?
                new ObjectParameter("doc_no", doc_no) :
                new ObjectParameter("doc_no", typeof(int));
    
            var narrParameter = narr != null ?
                new ObjectParameter("narr", narr) :
                new ObjectParameter("narr", typeof(string));
    
            var code_valueParameter = code_value.HasValue ?
                new ObjectParameter("code_value", code_value) :
                new ObjectParameter("code_value", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("p_stock_trans", dateParameter, refParameter, qty_inParameter, qty_outParameter, idParameter, doc_noParameter, narrParameter, code_valueParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}