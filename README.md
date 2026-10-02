# 🛒 EcommerceCheckout

![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![xUnit](https://img.shields.io/badge/Testes-xUnit-5C2D91?style=for-the-badge)
![License](https://img.shields.io/badge/Licença-MIT-green?style=for-the-badge)

Uma solução .NET para gerenciar o cálculo de cupons, pontos de fidelidade e frete de uma loja online, com cobertura completa de testes unitários usando **xUnit**. 📦

> [!NOTE]
> Este projeto foi desenvolvido como atividade prática da disciplina de **Garantia da Qualidade de Software**, com foco em testes unitários no ecossistema .NET.

---

## 📖 Sobre o projeto

O `PedidoService` implementa três regras de negócio de um checkout de e-commerce, cada uma cobrindo um tipo de retorno diferente — **string**, **int** e **bool** — para praticar os três principais tipos de asserção do xUnit.

| Método | Retorno | O que faz |
|---|:---:|---|
| `GerarCodigoRastreio(regiao, numeroPedido)` | `string` | Une a região em maiúsculas com o número do pedido preenchido com zeros à esquerda (4 dígitos). Ex: `"sudeste", 42` → `"SUDESTE-0042"` |
| `CalcularPontosFidelidade(valorTotal)` | `int` | Para cada R$ 10 em compras, soma 2 pontos de fidelidade. Ex: `150` → `30` pontos |
| `TemDireitoAFreteGratis(valorTotal, eClienteVIP)` | `bool` | Retorna `true` se o valor total for **≥ R$ 200** OU se o cliente for **VIP** |

---

## 🧪 Testes unitários

A suíte de testes, no projeto `EcommerceCheckout.Tests`, cobre os três métodos usando o atributo `[Fact]` do xUnit:

| Teste | Tipo de asserção | O que valida |
|---|---|---|
| `GerarCodigoRastreio_DeveGerarMascaraExata` | `Assert.Equal` | Máscara exata do código de rastreio (`"SUDESTE-0042"`) |
| `CalcularPontosFidelidade_DeveCalcularPontosCorretamente` | `Assert.Equal` | Cálculo de pontos (`150 → 30`) |
| `TemDireitoAFreteGratis_DeveRetornarTrueQuandoClienteVIPAbaixoDe200` | `Assert.True` | Frete grátis para cliente VIP, mesmo abaixo de R$ 200 |
| `TemDireitoAFreteGratis_DeveRetornarFalseQuandoNaoVIPAbaixoDe200` | `Assert.False` | Bloqueio do frete grátis para cliente não-VIP abaixo de R$ 200 |

> [!IMPORTANT]
> O método `bool` foi coberto por **dois** testes separados (`True` e `False`) para validar explicitamente os dois caminhos possíveis da regra de frete grátis.

---

## 🚀 Como executar

### Pré-requisitos

![.NET SDK](https://img.shields.io/badge/Requer-.NET%2010%20SDK-blue?style=flat-square)

Você precisa ter o [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado. Para conferir sua versão:

```bash
dotnet --version
```

### Instalação

```bash
git clone https://github.com/JoTaP-MX/ecommerce-checkout-xunit.git
cd ecommerce-checkout-xunit
```

### Rodando os testes

```bash
dotnet test
```

### Exemplo de saída
