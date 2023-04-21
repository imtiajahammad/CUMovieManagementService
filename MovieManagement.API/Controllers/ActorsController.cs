using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActorsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    public ActorsController(IUnitOfWork unitOfWork)
    {
        this._unitOfWork = unitOfWork;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var actorsFromRepo = _unitOfWork.ActorRepository.GetAll();
        return Ok(actorsFromRepo);
    }
    [HttpGet("movies")]
    public ActionResult GetWithMovies()
    {
        var actorsFromRepo = _unitOfWork.ActorRepository.GetActorsWithMovies();
        return Ok(actorsFromRepo);
    }
}
