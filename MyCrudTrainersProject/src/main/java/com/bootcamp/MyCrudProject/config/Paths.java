package com.bootcamp.MyCrudProject.config;

public enum Paths  {

    REDIRECT("redirect:/");
    
    private String url;

    private Paths(String url) {
        this.url = url;
    }

    public String getUrl() {
        return url;
    }
    
}
