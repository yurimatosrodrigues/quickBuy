import { Component } from "@angular/core";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public email = "yuimatos.tuti@gmail.com";
  
  entrar() {
    alert(this.email);
  }
  
}
