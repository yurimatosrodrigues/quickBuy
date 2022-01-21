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
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;

  constructor(private produtoServico: ProdutoServico) {

  }

  ngOnInit(): void {
    this.produto = new Produto();
  }

  public inputChange(files: FileList) {
    this.ativar_spinner = true;
    this.arquivoSelecionado = files.item(0);
    this.produtoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        nomeArquivo => {
          this.produto.nomeArquivo = nomeArquivo;
          alert(this.produto.nomeArquivo);
          this.ativar_spinner = false;
        },
        e => {
          console.log(e.error);
          this.ativar_spinner = false;
        }
      );
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
