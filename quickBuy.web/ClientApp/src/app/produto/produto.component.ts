import { Component } from "@angular/core";
import { OnInit } from "../../../node_modules/@angular/core/core";
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";

@Component({
  selector: "app-produto", //nome da tag HTML onde o componente vai ser renderizado
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})

export class ProdutoComponent implements OnInit{
  public produto: Produto;

  constructor(private produtoServico: ProdutoServico) {

  }

  ngOnInit(): void {
    this.produto = new Produto();
  }

  public cadastrar() {    
    this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);

        },
        e => {
          console.log(e.error)
        }
      );
  }

}
