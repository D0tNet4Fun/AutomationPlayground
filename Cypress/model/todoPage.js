export const todoPage = {
  url: "https://example.cypress.io/todo",
  open: () => cy.visit(todoPage.url),
  // elements
  listItems: () => cy.get('.todo-list li')
};

// todo: interface, TS?