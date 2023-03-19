# MyProject(In Progress)

Plan to build a e-commerce store with online payment

## Technology
.Net(v7), EF, Angular(v15)

## Backend
Mainly use .Net Core 7 to build the backend services.

### API - Controllers
- AutoMapper
- ErrorHandler
- Pagination and Filters


### Infrastructure - Repository, DbContext, Services


### Core - Entities, Interfaces


## Frontend
Mainly use Angular 15 to build the frontend UI and features.

### Core Module - core
- NavBar
- ErrorHandler: test errors, server errors, not found errors
- Interceptor: errors


### Shared Module - shared
- Models: includes product, brand, type, pagination, shopParams.
- Paging Header & Pager: reusable paging components.


### Feature Module - shop
- Shop Service: connect to backend API services, eg. getProducts, getBrands, getTypes.
- Shop Component: includes filters with types and brands, and sorts with name and price.
- Product Items: display the products in cards
- Pagination
- Product details
- Shop Routing: lazy loading