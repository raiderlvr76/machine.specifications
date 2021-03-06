﻿using System;
using Rhino.Mocks;

namespace Machine.Specifications.DevelopWithPassion.Rhino
{
    public class RhinoMocksMockFactory : MockFactory
    {
        public Dependency create_stub<Dependency>() where Dependency : class
        {
            return MockRepository.GenerateStub<Dependency>();
        }

        public object create_stub(Type type)
        {
            return MockRepository.GenerateStub(type);
        }
    }
}