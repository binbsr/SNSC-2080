using Microsoft.AspNetCore.Mvc;

public class TestController: Controller
{
    public string GetName()
    {
        return "Siddhanath Science Campus";
    }

    public IActionResult Name()
    {
        return View();
    }

} 