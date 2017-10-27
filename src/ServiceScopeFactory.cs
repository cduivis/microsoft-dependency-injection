﻿using Microsoft.Extensions.DependencyInjection;

namespace Unity.DependencyInjection
{
  public class ServiceScopeFactory : IServiceScopeFactory
  {
    private readonly IUnityContainer container;

    public ServiceScopeFactory(IUnityContainer container)
    {
      this.container = container;
    }

    public IServiceScope CreateScope()
    {
      return container.Resolve<IServiceScope>();
    }
  }
}