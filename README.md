# MyProject(In Progress)

Plan to build a e-commerce store with online payment


## Technology
.Net(v7), Entity Framework, Angular(v15)

## Backend
Mainly use .Net Core 7 to build the backend API, data entities and services.

### API - Controllers
- AutoMapper
- ErrorHandler
- Pagination and Filters
- Identity Service

### Infrastructure - Repository, DbContext, Services
- Database Migrations
- Data Seeding
- Redis

### Core - Entities, Interfaces
- Database Entities: Product, ProductBrand, ProductType, Basket, Identity
- Specifications
- Token Service

## Frontend
Mainly use Angular 15 to build the frontend UI and features.

### Core Module - core
- NavBar: display basket
- ErrorHandler: test errors, server errors, not found errors
- Interceptor: errors, loading
- Section Headers: breadcrumbs

### Shared Module - shared
- Models: includes product, brand, type, pagination, shopParams, basket.
- Paging Header & Pager: reusable paging components.

### Feature Module - shop
- Shop Service: connect to backend API services, eg. getProducts, getBrands, getTypes.
- Shop Component: includes filters with types and brands, and sorts with name and price.
- Product Items: display the products in cards
- Pagination
- Product details
- Shop Routing: lazy loading

### Other Features
- Home: a homepage includes a sliding
- Basket: the shopping cart of users
- Checkout