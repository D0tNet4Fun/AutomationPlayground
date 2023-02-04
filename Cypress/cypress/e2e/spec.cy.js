/// <reference types="cypress" />

describe('template spec', () => {
  it('passes', () => {
    cy.visit('https://example.cypress.io/todo')//.debug();
    cy.get('.todo-list li').first().should('have.text', 'Pay electric bill')
    cy.get('.todo-list li').last().should('have.text', 'Walk the dog')
    cy.get('.todo-list li').should('have.length', 2)
  })
})