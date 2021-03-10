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
    public class FilmsController : ControllerBase
    {
        private readonly ApplicationContext ctx;
        public FilmsController(ApplicationContext _ctx)
        {
            ctx = _ctx;
        }

        [HttpGet]
        public ResultDto GetFilms()
        {
            try
            {
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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

        [HttpPost("AddFilm")]
        public ResultDto Add([FromBody] FilmDto dto)
        {
            try
            {
                Film film = new Film()
                {
                    Name = dto.Name,
                    Year = dto.Year,
                    GenreId = ctx.Genres.FirstOrDefault(x => x.Name == dto.GenreName).Id
                };
                ctx.Films.Add(film);
                ctx.SaveChangesAsync();
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Successfully created"
                };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccessful = false,
                    Message = "Something goes wrong!"
                };
            }
        }

        [HttpPost]
        [Route("Delete/{id}")]
        public ResultDto DeleteFilm([FromRoute] int id)
        {
            try
            {
                Film f = ctx.Films.First(x => x.Id == id);
                ctx.Films.Remove(f);
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
        public ResultDto UpdateFilm([FromBody] FilmDto film)
        {
            try
            {
                Film f = ctx.Films.First(x => x.Id == film.Id);
                f.Name = film.Name;
                f.Year = film.Year;
                f.GenreId = ctx.Genres.FirstOrDefault(x => x.Name == film.GenreName).Id;
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
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderBy(x=>x.Name).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderByDescending(x => x.Name).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
        [Route("SortYear")]
        public ResultDto SortYear()
        {
            try
            {
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderBy(x => x.Year).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
        [Route("SortYearD")]
        public ResultDto SortYearD()
        {
            try
            {
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderByDescending(x => x.Year).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
        [Route("SortGenre")]
        public ResultDto SortGenre()
        {
            try
            {
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderBy(x => x.GenreName).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
        [Route("SortGenreD")]
        public ResultDto SortGenreD()
        {
            try
            {
                var res = ctx.Films.Select(x => new FilmDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    GenreName = x.Genre.Name,
                    GenreId = x.GenreId
                }).OrderByDescending(x => x.GenreName).ToList();
                return new CollectionResultDto<FilmDto> { IsSuccessful = true, Message = "OK", ResultCollection = res };
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
