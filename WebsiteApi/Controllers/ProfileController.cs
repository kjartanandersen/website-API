using System;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using API.Services;
using API.Models;

namespace API.Controllers;

[Controller]
[Route("/api/[controller]")]
public class ProfileController : ControllerBase
{

    private readonly ProfileService _mongoDBService;

    public ProfileController(ProfileService mongoDBService)
    {
        _mongoDBService = mongoDBService;
    }

    [HttpGet]
    public async Task<List<ProfileDto>> Get()
    {
        return await _mongoDBService.GetAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProfileDto profile)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        await _mongoDBService.CreateAsync(profile);
        return CreatedAtAction(nameof(Get), new { id = profile.Id }, profile);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] ProfileDto profile)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        await _mongoDBService.UpdateAsync(profile);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mongoDBService.DeleteAsync(id);
        return NoContent();
    }

}