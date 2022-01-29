define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LojaCarrinhoCompras = void 0;
    var LojaCarrinhoCompras = /** @class */ (function () {
        function LojaCarrinhoCompras() {
            this.produtos = [];
        }
        LojaCarrinhoCompras.prototype.adicionar = function (produto) {
            var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
            this.produtos = JSON.parse(produtoLocalStorage);
            if (!this.produtos.indexOf(produto)) {
                this.produtos.push(produto);
            }
            localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
        };
        LojaCarrinhoCompras.prototype.obterProdutos = function () {
            var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
            if (produtoLocalStorage)
                return JSON.parse(produtoLocalStorage);
        };
        LojaCarrinhoCompras.prototype.removerProduto = function (produto) {
            var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
            if (produtoLocalStorage) {
                this.produtos = JSON.parse(produtoLocalStorage);
                this.produtos = this.produtos.filter(function (p) { return p.id != produto.id; });
                localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
            }
        };
        LojaCarrinhoCompras.prototype.atualizar = function (produtos) {
            localStorage.setItem("produtoLocalStorage", JSON.stringify(produtos));
        };
        return LojaCarrinhoCompras;
    }());
    exports.LojaCarrinhoCompras = LojaCarrinhoCompras;
});
//# sourceMappingURL=loja.carrinho.compras.js.map