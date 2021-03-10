using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Net_Core_08_03_2021.Models;
using ASP.Net_Core_08_03_2021.Models.DTO;
using ASP.Net_Core_08_03_2021.Models.DTO.Result;
using ASP.Net_Core_08_03_2021.Models.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_08_03_2021.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ApplicationContext ctx;
        public GenreController(ApplicationContext _ctx)
        {
            ctx = _ctx;
        }

        [HttpGet]
        public ResultDto GetAllGenre()
        {
            try
            {
                var res = ctx.Genres.Select(x => new GenreDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

                return new CollectionResultDto<GenreDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };

            }
            catch (Exception )
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong"
                };

                throw;
            }

        }

        [HttpPost]
        [Route("AddGenre")]
        public ResultDto AddGenre([FromBody] GenreDto dto)
        {
            try
            {
                Genre genre = new Genre()
                {
                    Name = dto.Name
                };
                ctx.Genres.Add(genre);
                ctx.SaveChangesAsync();
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Successfully created"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong!"
                };
                throw;
            }

        }

        [HttpPost]
        [Route("Delete/{id}")]
        public ResultDto DeleteGenre([FromRoute] int id)
        {
            try
            {
                Genre f = ctx.Genres.First(x => x.Id == id);
                ctx.Genres.Remove(f);
                ctx.SaveChanges();
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Successfully created"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong!"
                };
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public ResultDto UpdateFilm([FromBody] GenreDto genre)
        {
            try
            {
                Genre g = ctx.Genres.First(x => x.Id == genre.Id);
                g.Name = genre.Name;
                ctx.SaveChanges();
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Successfully created"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong!"
                };
                throw;
            }
        }


        [HttpGet]
        [Route("SortName")]
        public ResultDto SortName()
        {
            try
            {
                var res = ctx.Genres.Select(x => new GenreDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).OrderBy(x => x.Name).ToList();
                return new CollectionResultDto<GenreDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong"
                };
                throw;
            }
        }

        [HttpGet]
        [Route("SortNameD")]
        public ResultDto SortNameD()
        {
            try
            {
                var res = ctx.Genres.Select(x => new GenreDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).OrderByDescending(x => x.Name).ToList();
                return new CollectionResultDto<GenreDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong"
                };
                throw;
            }
        }


    }
}
