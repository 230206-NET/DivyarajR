﻿using Models;

namespace Services;
    public class TicketService
    {
        // Dependency Injection: is a design pattern where the dependency of a class is injected through the constructor instead of the class itself having a specific knowledge of its dependency, or instantiating itself
        // This example here is actually a combination of dependency injection and dependency inversion
        // This allows for more flexible change in implementation, also this pattern makes unit testing much simpler
       // private readonly IRepository _repo;
        public TicketService() {
         //   _repo = repo;
        }
    }