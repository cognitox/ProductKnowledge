﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace KnowSL.Database
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DB_9B214B_ProductKnowledgeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DB_9B214B_ProductKnowledgeEntities object using the connection string found in the 'DB_9B214B_ProductKnowledgeEntities' section of the application configuration file.
        /// </summary>
        public DB_9B214B_ProductKnowledgeEntities() : base("name=DB_9B214B_ProductKnowledgeEntities", "DB_9B214B_ProductKnowledgeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DB_9B214B_ProductKnowledgeEntities object.
        /// </summary>
        public DB_9B214B_ProductKnowledgeEntities(string connectionString) : base(connectionString, "DB_9B214B_ProductKnowledgeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DB_9B214B_ProductKnowledgeEntities object.
        /// </summary>
        public DB_9B214B_ProductKnowledgeEntities(EntityConnection connection) : base(connection, "DB_9B214B_ProductKnowledgeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Ingredient> Ingredients
        {
            get
            {
                if ((_Ingredients == null))
                {
                    _Ingredients = base.CreateObjectSet<Ingredient>("Ingredients");
                }
                return _Ingredients;
            }
        }
        private ObjectSet<Ingredient> _Ingredients;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<IngredientDescription> IngredientDescriptions
        {
            get
            {
                if ((_IngredientDescriptions == null))
                {
                    _IngredientDescriptions = base.CreateObjectSet<IngredientDescription>("IngredientDescriptions");
                }
                return _IngredientDescriptions;
            }
        }
        private ObjectSet<IngredientDescription> _IngredientDescriptions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<IngredientDescriptionType> IngredientDescriptionTypes
        {
            get
            {
                if ((_IngredientDescriptionTypes == null))
                {
                    _IngredientDescriptionTypes = base.CreateObjectSet<IngredientDescriptionType>("IngredientDescriptionTypes");
                }
                return _IngredientDescriptionTypes;
            }
        }
        private ObjectSet<IngredientDescriptionType> _IngredientDescriptionTypes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<NewsLetter> NewsLetters
        {
            get
            {
                if ((_NewsLetters == null))
                {
                    _NewsLetters = base.CreateObjectSet<NewsLetter>("NewsLetters");
                }
                return _NewsLetters;
            }
        }
        private ObjectSet<NewsLetter> _NewsLetters;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProductIngredientLink> ProductIngredientLinks
        {
            get
            {
                if ((_ProductIngredientLinks == null))
                {
                    _ProductIngredientLinks = base.CreateObjectSet<ProductIngredientLink>("ProductIngredientLinks");
                }
                return _ProductIngredientLinks;
            }
        }
        private ObjectSet<ProductIngredientLink> _ProductIngredientLinks;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Ingredients EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToIngredients(Ingredient ingredient)
        {
            base.AddObject("Ingredients", ingredient);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the IngredientDescriptions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToIngredientDescriptions(IngredientDescription ingredientDescription)
        {
            base.AddObject("IngredientDescriptions", ingredientDescription);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the IngredientDescriptionTypes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToIngredientDescriptionTypes(IngredientDescriptionType ingredientDescriptionType)
        {
            base.AddObject("IngredientDescriptionTypes", ingredientDescriptionType);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the NewsLetters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToNewsLetters(NewsLetter newsLetter)
        {
            base.AddObject("NewsLetters", newsLetter);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ProductIngredientLinks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProductIngredientLinks(ProductIngredientLink productIngredientLink)
        {
            base.AddObject("ProductIngredientLinks", productIngredientLink);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="Ingredient")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Ingredient : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Ingredient object.
        /// </summary>
        /// <param name="ingredientID">Initial value of the IngredientID property.</param>
        public static Ingredient CreateIngredient(global::System.Int32 ingredientID)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.IngredientID = ingredientID;
            return ingredient;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientID
        {
            get
            {
                return _IngredientID;
            }
            set
            {
                if (_IngredientID != value)
                {
                    OnIngredientIDChanging(value);
                    ReportPropertyChanging("IngredientID");
                    _IngredientID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IngredientID");
                    OnIngredientIDChanged();
                }
            }
        }
        private global::System.Int32 _IngredientID;
        partial void OnIngredientIDChanging(global::System.Int32 value);
        partial void OnIngredientIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="IngredientDescription")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class IngredientDescription : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new IngredientDescription object.
        /// </summary>
        /// <param name="ingredientDescriptionID">Initial value of the IngredientDescriptionID property.</param>
        /// <param name="ingredientID">Initial value of the IngredientID property.</param>
        /// <param name="ingredientDescriptionTypeID">Initial value of the IngredientDescriptionTypeID property.</param>
        public static IngredientDescription CreateIngredientDescription(global::System.Int32 ingredientDescriptionID, global::System.Int32 ingredientID, global::System.Int32 ingredientDescriptionTypeID)
        {
            IngredientDescription ingredientDescription = new IngredientDescription();
            ingredientDescription.IngredientDescriptionID = ingredientDescriptionID;
            ingredientDescription.IngredientID = ingredientID;
            ingredientDescription.IngredientDescriptionTypeID = ingredientDescriptionTypeID;
            return ingredientDescription;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientDescriptionID
        {
            get
            {
                return _IngredientDescriptionID;
            }
            set
            {
                if (_IngredientDescriptionID != value)
                {
                    OnIngredientDescriptionIDChanging(value);
                    ReportPropertyChanging("IngredientDescriptionID");
                    _IngredientDescriptionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IngredientDescriptionID");
                    OnIngredientDescriptionIDChanged();
                }
            }
        }
        private global::System.Int32 _IngredientDescriptionID;
        partial void OnIngredientDescriptionIDChanging(global::System.Int32 value);
        partial void OnIngredientDescriptionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientID
        {
            get
            {
                return _IngredientID;
            }
            set
            {
                OnIngredientIDChanging(value);
                ReportPropertyChanging("IngredientID");
                _IngredientID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IngredientID");
                OnIngredientIDChanged();
            }
        }
        private global::System.Int32 _IngredientID;
        partial void OnIngredientIDChanging(global::System.Int32 value);
        partial void OnIngredientIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientDescriptionTypeID
        {
            get
            {
                return _IngredientDescriptionTypeID;
            }
            set
            {
                OnIngredientDescriptionTypeIDChanging(value);
                ReportPropertyChanging("IngredientDescriptionTypeID");
                _IngredientDescriptionTypeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IngredientDescriptionTypeID");
                OnIngredientDescriptionTypeIDChanged();
            }
        }
        private global::System.Int32 _IngredientDescriptionTypeID;
        partial void OnIngredientDescriptionTypeIDChanging(global::System.Int32 value);
        partial void OnIngredientDescriptionTypeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Details
        {
            get
            {
                return _Details;
            }
            set
            {
                OnDetailsChanging(value);
                ReportPropertyChanging("Details");
                _Details = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Details");
                OnDetailsChanged();
            }
        }
        private global::System.String _Details;
        partial void OnDetailsChanging(global::System.String value);
        partial void OnDetailsChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="IngredientDescriptionType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class IngredientDescriptionType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new IngredientDescriptionType object.
        /// </summary>
        /// <param name="ingredientDescriptionTypeID">Initial value of the IngredientDescriptionTypeID property.</param>
        public static IngredientDescriptionType CreateIngredientDescriptionType(global::System.Int32 ingredientDescriptionTypeID)
        {
            IngredientDescriptionType ingredientDescriptionType = new IngredientDescriptionType();
            ingredientDescriptionType.IngredientDescriptionTypeID = ingredientDescriptionTypeID;
            return ingredientDescriptionType;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientDescriptionTypeID
        {
            get
            {
                return _IngredientDescriptionTypeID;
            }
            set
            {
                if (_IngredientDescriptionTypeID != value)
                {
                    OnIngredientDescriptionTypeIDChanging(value);
                    ReportPropertyChanging("IngredientDescriptionTypeID");
                    _IngredientDescriptionTypeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IngredientDescriptionTypeID");
                    OnIngredientDescriptionTypeIDChanged();
                }
            }
        }
        private global::System.Int32 _IngredientDescriptionTypeID;
        partial void OnIngredientDescriptionTypeIDChanging(global::System.Int32 value);
        partial void OnIngredientDescriptionTypeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="NewsLetter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NewsLetter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new NewsLetter object.
        /// </summary>
        /// <param name="newsLetterID">Initial value of the NewsLetterID property.</param>
        public static NewsLetter CreateNewsLetter(global::System.Int32 newsLetterID)
        {
            NewsLetter newsLetter = new NewsLetter();
            newsLetter.NewsLetterID = newsLetterID;
            return newsLetter;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NewsLetterID
        {
            get
            {
                return _NewsLetterID;
            }
            set
            {
                if (_NewsLetterID != value)
                {
                    OnNewsLetterIDChanging(value);
                    ReportPropertyChanging("NewsLetterID");
                    _NewsLetterID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("NewsLetterID");
                    OnNewsLetterIDChanged();
                }
            }
        }
        private global::System.Int32 _NewsLetterID;
        partial void OnNewsLetterIDChanging(global::System.Int32 value);
        partial void OnNewsLetterIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        public static Product CreateProduct(global::System.Int32 productID)
        {
            Product product = new Product();
            product.ProductID = productID;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_9B214B_ProductKnowledgeModel", Name="ProductIngredientLink")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductIngredientLink : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProductIngredientLink object.
        /// </summary>
        /// <param name="productIngredientLinkID">Initial value of the ProductIngredientLinkID property.</param>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="ingredientID">Initial value of the IngredientID property.</param>
        public static ProductIngredientLink CreateProductIngredientLink(global::System.Int32 productIngredientLinkID, global::System.Int32 productID, global::System.Int32 ingredientID)
        {
            ProductIngredientLink productIngredientLink = new ProductIngredientLink();
            productIngredientLink.ProductIngredientLinkID = productIngredientLinkID;
            productIngredientLink.ProductID = productID;
            productIngredientLink.IngredientID = ingredientID;
            return productIngredientLink;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductIngredientLinkID
        {
            get
            {
                return _ProductIngredientLinkID;
            }
            set
            {
                if (_ProductIngredientLinkID != value)
                {
                    OnProductIngredientLinkIDChanging(value);
                    ReportPropertyChanging("ProductIngredientLinkID");
                    _ProductIngredientLinkID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductIngredientLinkID");
                    OnProductIngredientLinkIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductIngredientLinkID;
        partial void OnProductIngredientLinkIDChanging(global::System.Int32 value);
        partial void OnProductIngredientLinkIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                OnProductIDChanging(value);
                ReportPropertyChanging("ProductID");
                _ProductID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductID");
                OnProductIDChanged();
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IngredientID
        {
            get
            {
                return _IngredientID;
            }
            set
            {
                OnIngredientIDChanging(value);
                ReportPropertyChanging("IngredientID");
                _IngredientID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IngredientID");
                OnIngredientIDChanged();
            }
        }
        private global::System.Int32 _IngredientID;
        partial void OnIngredientIDChanging(global::System.Int32 value);
        partial void OnIngredientIDChanged();

        #endregion

    
    }

    #endregion

    
}
