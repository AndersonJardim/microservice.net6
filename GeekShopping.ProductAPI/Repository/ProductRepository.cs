﻿using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model.Context;
using System.Runtime.CompilerServices;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductVO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> Update(ProductVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
