import { test, expect } from '@playwright/test';
import { todoPageBuilder } from '../model/todoPageBuilder';

test('todo using model', async ({ page }) => {
  const todoPage = todoPageBuilder(page);
  await todoPage.open();
  await expect(todoPage.list).toHaveCount(2);
  const items = await todoPage.list.all();
  await expect(items[0]).toContainText('Pay electric bill');
  await expect(items[1]).toContainText('Walk the dog');
});
