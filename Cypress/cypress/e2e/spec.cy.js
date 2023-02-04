/// <reference types="cypress" />

describe('template spec', () => {
  it('passes', () => {
    cy.visit('https://example.cypress.io/todo')//.debug();
    const listItemsSelector = '.todo-list li';
    cy.get(listItemsSelector).first().should('have.text', 'Pay electric bill')
    cy.get(listItemsSelector).last().should('have.text', 'Walk the dog')
    cy.get(listItemsSelector).should('have.length', 2)
  })
})