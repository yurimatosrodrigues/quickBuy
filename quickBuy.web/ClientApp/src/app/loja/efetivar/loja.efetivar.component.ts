import { Component, OnInit } from "@angular/core";
import { Produto } from "../../modelo/produto";
import { LojaCarrinhoCompras } from "../carrinho-compras/loja.carrinho.compras";

@Component({
  selector: "loja-efetivar",
  templateUrl: "./loja.efetivar.component.html",
  styleUrls: ["./loja.efetivar.component.css"]
})

export class LojaEfetivarComponent implements OnInit{
  public carrinhoCompras: LojaCarrinhoCompras;
  public produtos: Produto[];
  public total: number;

  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinhoCompras();
    this.produtos = this.carrinhoCompras.obterProdutos();
    this.atualizarTotal();
  }

  constructor() {

  }

  public atualizarPreco(produto: Produto, quantidade: number) {
    if (!produto.precoOriginal)
      produto.precoOriginal = produto.preco;

    if (quantidade <= 0) {
      quantidade = 1;
      produto.quantidade = quantidade
    }     

    produto.preco = produto.precoOriginal * quantidade;
    this.carrinhoCompras.atualizar(this.produtos);
    this.atualizarTotal()
  }

  public remover(produto: Produto) {
    this.carrinhoCompras.removerProduto(produto);
    this.produtos = this.carrinhoCompras.obterProdutos();
    this.atualizarTotal();
  }

  public atualizarTotal() {
    this.total = this.produtos.reduce((acc, produto) => acc + produto.preco, 0);
  }
}
