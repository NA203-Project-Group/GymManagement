﻿using System;
using System.Collections.Generic;
using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;

namespace GymManagement.Application.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CampaignService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public List<CampaignQueryViewModel> GetAll()
        {
            var campaigns =  _unitOfWork.Campaigns.GetAll();
            return  _mapper.Map<List<CampaignQueryViewModel>>(campaigns);
        }

        public CampaignQueryViewModel GetById(int id)
        {
            var campaign = _unitOfWork.Campaigns.GetById(id);
            return _mapper.Map<CampaignQueryViewModel>(campaign);
        }

        public bool Create(CampaignCommandViewModel model)
        {
            var campaign = _mapper.Map<Campaign>(model);
            _unitOfWork.Campaigns.Create(campaign);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool Update(CampaignCommandViewModel model)
        {
            var campaign = _mapper.Map<Campaign>(model);
            _unitOfWork.Campaigns.Update(campaign);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var campaign = _unitOfWork.Campaigns.GetById(id);
            _unitOfWork.Campaigns.Delete(campaign);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;
        }
    }
}