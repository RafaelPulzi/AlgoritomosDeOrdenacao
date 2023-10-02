import os


class Vetor:
    def __init__(self):
        self.vetor = []

    def adicionar_elemento(self, elemento):
        self.vetor.append(elemento)

    def remover_elemento(self, elemento):
        if elemento in self.vetor:
            self.vetor.remove(elemento)
        else:
            print("Elemento não encontrado no vetor.")

    def imprimir_vetor(self):
        print("\nVetor atual:", self.vetor)


def main():
    os.system('cls' if os.name == 'nt' else 'clear')  # Limpa o terminal

    vetor = Vetor()

    print("Bem-vindo ao exemplo de vetores em Python!")

    while True:

        print("\nO que você gostaria de fazer?\n")
        print("1. Adicionar um elemento")
        print("2. Remover um elemento")
        print("3. Imprimir o vetor")
        print("4. Sair")
        opcao = input("\nDigite a opção desejada: ")

        if opcao == "1":
            elemento = input("Digite o elemento que deseja adicionar: ")
            vetor.adicionar_elemento(elemento)
            print("Vetor atualizado:", vetor.vetor)

        elif opcao == "2":
            elemento = input("Digite o elemento que deseja remover: ")
            vetor.remover_elemento(elemento)
            print("Vetor atualizado:", vetor.vetor)

        elif opcao == "3":
            vetor.imprimir_vetor()

        elif opcao == "4":
            print("Saindo do programa. Até logo!")
            break

        else:
            print("Opção inválida. Por favor, escolha uma opção válida.")


if __name__ == "__main__":
    main()