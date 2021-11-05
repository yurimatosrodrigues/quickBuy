import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;
  //private router: Router;

  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  entrar() {    
    if (this.usuario.email == "teste@teste.com.br" && this.usuario.senha == "12345678") {
      sessionStorage.setItem("usuario-autenticado", "1"); //acontece dentro do contexto do usuário
      this.router.navigate(['/']);
    }
  }  
}
