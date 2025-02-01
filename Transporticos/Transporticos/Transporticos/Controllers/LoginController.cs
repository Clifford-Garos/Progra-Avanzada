using Microsoft.AspNetCore.Mvc;
using SM_ProyectoWeb.Models;

namespace SM_ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  // Protección contra ataques CSRF
        public IActionResult IniciarSesion(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Si hay errores de validación, retornamos la misma vista con los mensajes de error
                return View(model);
            }

            // Aquí realizarías tu lógica de autenticación:
            // Por ejemplo, verificar en la base de datos si el usuario y contraseña son correctos.

            bool loginValido = false; // Cambia esto por tu lógica real

            if (loginValido)
            {
                // Redirigir a alguna página principal o Dashboard
                return RedirectToAction("Principal", "Home");
            }
            else
            {
                // Si el login no es válido, puedes agregar un mensaje de error al ModelState
                ModelState.AddModelError(string.Empty, "Credenciales inválidas.");
                return View(model);
            }
        }

        public IActionResult Principal()
        {
            return View();
        }
    }
}
