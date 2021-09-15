package com.bootcamp.MyCrudProject.service;

import com.bootcamp.MyCrudProject.model.Trainer;
import com.bootcamp.MyCrudProject.repository.TrainerRepository;
import com.bootcamp.MyCrudProject.util.ValidatorUtil;
import com.bootcamp.MyCrudProject.validators.TrainerCreationValidator;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TrainerService {
    
    @Autowired
    private TrainerRepository repo;
    
    public List<Trainer> allTrainers() {
        return repo.findAll();
    }
    
    public void save(Trainer trainer) {
        repo.save(trainer);
    }
    
    public Trainer get(long id) {
        return repo.findById(id).get();
    }
    
    public void delete(long id) {
        repo.deleteById(id);
    }
    public void validateTrainer(Trainer trainer){
        ValidatorUtil.validate(trainer, new TrainerCreationValidator());
        
    }

}
