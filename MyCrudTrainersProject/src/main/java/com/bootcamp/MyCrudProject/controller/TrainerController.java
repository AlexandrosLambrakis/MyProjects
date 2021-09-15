package com.bootcamp.MyCrudProject.controller;

import com.bootcamp.MyCrudProject.model.Trainer;
import static com.bootcamp.MyCrudProject.config.Paths.REDIRECT;
import com.bootcamp.MyCrudProject.service.TrainerService;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class TrainerController {

    @Autowired
    private TrainerService service;

    @GetMapping("/")
    public String homePage(Model model) {
        List<Trainer> listtrainer = service.allTrainers();
        model.addAttribute("listtrainer", listtrainer);
        System.out.println("Select/");
        return "index";
    }

    @GetMapping("/new")
    public String create(Model model) {
        model.addAttribute("trainer", new Trainer());
        return "new";
    }

    @RequestMapping(value = "/save", method = RequestMethod.POST)
    public String saveTrainer(@ModelAttribute("trainer") Trainer trainer) {
        service.validateTrainer(trainer);
        service.save(trainer);
        return REDIRECT.getUrl();
    }


    @RequestMapping("/edit/{id}")
    public ModelAndView showEditTrainerPage(@PathVariable(name = "id") int id) {
        ModelAndView mav = new ModelAndView("new");
        Trainer trainer = service.get(id);
        mav.addObject("trainer", trainer);
        return mav;
    }

    @RequestMapping("/delete/{id}")
    public String deleteTrainer(@PathVariable(name = "id") int id) {
        service.delete(id);
        return REDIRECT.getUrl();
    }
}
