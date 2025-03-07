using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    private GameObject enemyPrefab;
    private GameObject enemyInstance;

    [SetUp]
    public void Setup()
    {
        TestContext.Progress.WriteLine("Setting up the test...");

        // Загружаем префаб Enemy
        enemyPrefab = Resources.Load<GameObject>("Enemy");
        // Создаем экземпляр Enemy
        enemyInstance = Object.Instantiate(enemyPrefab);
    }

    [Test]
    public void NewTestScriptSimplePasses()
    {
        TestContext.Progress.WriteLine("Running NewTestScriptSimplePasses...");

        // Проверяем, что объект Enemy был создан
        Assert.IsNotNull(enemyInstance, "Enemy instance should not be null");

        TestContext.Progress.WriteLine("Test NewTestScriptSimplePasses passed.");
    }

    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        TestContext.Progress.WriteLine("Running NewTestScriptWithEnumeratorPasses...");

        // Задаем начальную
        Vector3 startPosition = enemyInstance.transform.position;

        // Ждем один кадр
        yield return null;

        // Проверяем, что объект переместился
        Assert.That(enemyInstance.transform.GetChild(0).transform.position.y, Is.GreaterThan(-0.8f));

        TestContext.Progress.WriteLine("Test NewTestScriptWithEnumeratorPasses passed.");
    }

    [TearDown]
    public void Teardown()
    {
        TestContext.Progress.WriteLine("Tearing down the test...");

        // Удаляем экземпляр Enemy после теста
        Object.DestroyImmediate(enemyInstance);
    }
}