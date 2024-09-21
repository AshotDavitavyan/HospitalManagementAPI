using Domain.Models;

namespace Domain.Interfaces;

public interface ICabinetRepository
{
	public Task<Cabinet> GetByIdAsync(int doctorCabinetId);
}