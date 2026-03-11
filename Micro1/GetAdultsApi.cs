
[HttpGet("adults")]
public IActionResult GetAdultsApi{

    var adults = _context.Users.Where(u => u.Age >= 18)
        .Select(u => u.Name)
        .ToList();

    return Ok(adults);
    
}