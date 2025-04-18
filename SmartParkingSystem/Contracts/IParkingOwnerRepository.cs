﻿using SmartParkingSystem.Entities.Models;

namespace SmartParkingSystem.Contracts
{
    public interface IParkingOwnerRepository
    {
        Task<List<ParkingOwner>> GetListParkingOwners();
        Task<ParkingOwner> GetParkingOwner(int id);
        Task<ParkingOwner> GetParkingOwnerByEmail(string email);
        Task DeleteParkingOwner(ParkingOwner ParkingOwner);
        Task<ParkingOwner> AddParkingOwner(ParkingOwner ParkingOwner);
        Task UpdateParkingOwner(ParkingOwner ParkingOwner);
    }
}
