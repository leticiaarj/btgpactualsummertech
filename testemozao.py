class Pessoa:
    def __init__(self, nome, ufOrigem, disponibilidade):
        self.nome = nome
        self.ufOrigem = ufOrigem
        self.disponibilidade = disponibilidade

    def toString(self):
        return f'{self.nome} {self.ufOrigem} {self.disponibilidade}'

if __name__ == "__main__":
    pessoa1 = Pessoa("Gabriel", "DF", True)
    pessoa2 = Pessoa("Lety", "DF", False)

    print(pessoa1.toString())