package com.bootcamp.MyCrudProject.validators;

import com.bootcamp.MyCrudProject.model.Trainer;
import org.springframework.validation.Errors;
import org.springframework.validation.Validator;

public class TrainerCreationValidator implements Validator {

    @Override
    public boolean supports(Class<?> type) {
        return Trainer.class.equals(type);
    }

    @Override
    public void validate(Object o, Errors errors) {
        Trainer trainer = (Trainer) o;
        if (trainer.getFirstname() == null || (trainer.getFirstname().length() < 2 || trainer.getFirstname().length() > 50)) {
            errors.rejectValue("firstname", "Invalid Firstname");
        }
        if (trainer.getLastname() == null || (trainer.getLastname().length() < 2 || trainer.getLastname().length() > 50)) {
            errors.rejectValue("lastname", "Invalid Lastname");
        }
        if (trainer.getCourse() == null || (trainer.getCourse().length() < 2 || trainer.getCourse().length() > 50)) {
            errors.rejectValue("course", "Invalid Course");
        }
        if (trainer.getPhone() == null || (trainer.getPhone().length() < 10 || trainer.getPhone().length() > 20
                || trainer.getPhone().matches("[7-9][0-9] {9}"))) {
            errors.rejectValue("phone", "Invalid Phone");
        }
        if (trainer.getEmail() == null || trainer.getEmail().length() > 50
                || !trainer.getEmail().matches("^(.+)@(.+)$")) {
            errors.rejectValue("email", "Invalid Email");
        }

    }

}
