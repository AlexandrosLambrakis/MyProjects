package com.bootcamp.MyCrudProject.util;

import static com.bootcamp.MyCrudProject.util.HttpExceptionFactory.badRequest;
import java.util.stream.Collectors;
import org.springframework.context.support.DefaultMessageSourceResolvable;
import org.springframework.validation.BeanPropertyBindingResult;
import org.springframework.validation.Errors;
import org.springframework.validation.Validator;

public class ValidatorUtil {

    private ValidatorUtil() {
        
    }
    
    public static void validate(Object data, Validator validator) {
        Errors errors = new BeanPropertyBindingResult(data, "data");
        validator.validate(data, errors);

        if (errors.hasErrors())
            throw badRequest(
                    errors.getFieldErrors().stream()
                            .map(DefaultMessageSourceResolvable::getCode)
                            .collect(Collectors.toList())
                            .toString());
    }
    
}
