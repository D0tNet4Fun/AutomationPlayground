import { test, expect } from '@playwright/test';
import { TodoPage } from '../model/TodoPage';

test('todo using model', async ({ page }) => {
  const todoPage = new TodoPage(page);
  await todoPage.goto();
  await expect(todoPage.list).toHaveCount(2);
  const items = await todoPage.list.all();
  await expect(items[0]).toContainText('Pay electric bill');
  await expect(items[1]).toContainText('Walk the dog');
});
