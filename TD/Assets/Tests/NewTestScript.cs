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

        // ��������� ������ Enemy
        enemyPrefab = Resources.Load<GameObject>("Enemy");
        // ������� ��������� Enemy
        enemyInstance = Object.Instantiate(enemyPrefab);
    }

    [Test]
    public void NewTestScriptSimplePasses()
    {
        TestContext.Progress.WriteLine("Running NewTestScriptSimplePasses...");

        // ���������, ��� ������ Enemy ��� ������
        Assert.IsNotNull(enemyInstance, "Enemy instance should not be null");

        TestContext.Progress.WriteLine("Test NewTestScriptSimplePasses passed.");
    }

    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        TestContext.Progress.WriteLine("Running NewTestScriptWithEnumeratorPasses...");

        // ������ ���������
        Vector3 startPosition = enemyInstance.transform.position;

        // ���� ���� ����
        yield return null;

        // ���������, ��� ������ ������������
        Assert.That(enemyInstance.transform.GetChild(0).transform.position.y, Is.GreaterThan(-0.8f));

        TestContext.Progress.WriteLine("Test NewTestScriptWithEnumeratorPasses passed.");
    }

    [TearDown]
    public void Teardown()
    {
        TestContext.Progress.WriteLine("Tearing down the test...");

        // ������� ��������� Enemy ����� �����
        Object.DestroyImmediate(enemyInstance);
    }
}