# 📚 CEU - Centro de Ensino Universal

Projeto acadêmico desenvolvido com arquitetura moderna utilizando **DDD**, **CQRS**, **MediatR**, e autenticação com **JWT + Identity**.

Este projeto simula uma plataforma de ensino com gestão de cursos, alunos e pagamentos.

---

## 🧱 Arquitetura

O projeto é dividido por **Bounded Contexts**, seguindo princípios do **Domain-Driven Design (DDD)**:

- **CEU.Core**: Camada central com entidades base, exceções de domínio, interfaces e abstrações.
- **CEU.Conteudo**: Gestão de cursos e conteúdos.
- **CEU.Aluno**: Cadastro e gerenciamento de alunos.
- **CEU.Pagamento**: Processamento de pagamentos.
- **CEU.WebApi**: Interface de entrada da aplicação (REST API).