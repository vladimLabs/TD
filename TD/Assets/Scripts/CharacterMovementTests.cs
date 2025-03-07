using UnityEngine.TestTools;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterMovementTests : MonoBehaviour
{
    [UnityTest]
    public IEnumerator CharacterMovesForward()
    {
        // �������� ��������� ������ ���������
        GameObject character = new GameObject();
        CharacterController controller = character.AddComponent<CharacterController>();

        // ������� ��������� �������
        Vector3 startPosition = character.transform.position;
        character.transform.position = startPosition;

        // ��������� �������� ������
        controller.Move(Vector3.forward * Time.deltaTime);

        // ��������� ���� ����
        yield return null;

        // ���������, ��� �������� ������������
        Assert.IsTrue(character.transform.position.z > startPosition.z);
    }
}