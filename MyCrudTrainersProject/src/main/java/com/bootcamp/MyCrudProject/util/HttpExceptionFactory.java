package com.bootcamp.MyCrudProject.util;

import org.springframework.http.HttpStatus;
import org.springframework.web.server.ResponseStatusException;

public class HttpExceptionFactory {

    private HttpExceptionFactory() {
        
    }
    
    public static ResponseStatusException badRequest(String msg) {
        return new ResponseStatusException(HttpStatus.BAD_REQUEST, msg);
    }
    
}
