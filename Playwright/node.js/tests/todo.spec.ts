import { test, expect } from '@playwright/test';

test('todo', async ({ page }) => {
  await page.goto('https://example.cypress.io/todo');
  const list = page.locator('css=.todo-list li');
  await expect(list).toHaveCount(2);
  const items = await list.all();
  await expect(items[0]).toContainText('Pay electric bill');
  await expect(items[1]).toContainText('Walk the dog');
});
