﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace JCE.Core.Dependency
{
    /// <summary>
    /// 作用域
    /// </summary>
    internal class Scope : IScope
    {
        #region Property(属性)

        /// <summary>
        /// Autofac 作用域
        /// </summary>
        private readonly ILifetimeScope _scope;
        #endregion

        #region Constructor(构造函数)
        /// <summary>
        /// 初始化一个<see cref="Scope"/>类型的实例
        /// </summary>
        /// <param name="scope">Autofac作用域</param>
        public Scope(ILifetimeScope scope)
        {
            _scope = scope;
        }
        #endregion

        /// <summary>
        /// 释放对象
        /// </summary>
        public void Dispose()
        {
            _scope.Dispose();
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <typeparam name="T">实例类型</typeparam>
        /// <returns></returns>
        public T Create<T>()
        {
            return _scope.Resolve<T>();
        }

        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="type">对象类型</param>
        /// <returns></returns>
        public object Create(Type type)
        {
            return _scope.Resolve(type);
        }
    }
}
