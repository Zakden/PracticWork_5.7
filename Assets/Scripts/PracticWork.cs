using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PracticWork : MonoBehaviour
{
    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� ��������� ���������"
    /// </summary>
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � ��������� �� {min} �� {max} ������������: {got} - {message}");
    }

    /// <summary>
    /// ����� ��������� ����� ������ ����� � ���������� ��������� 
    /// </summary>
    /// <param name="min">����������� �������� ���������</param>
    /// <param name="max">������������ �������� ���������</param>
    /// <returns>����� ����� ������ �����</returns>
    private int SumEvenNumbersInRange(int min, int max)
    {
        int sum = 0;
        for (int i = min; i < max; i++)
        {
            if(i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������ ����� � �������� �������"
    /// </summary>
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"����� ������ ����� � �������� �������: {got} - {message}");
    }

    /// <summary>
    /// ����� ��������� ����� ������ ����� � ������� 
    /// </summary>
    /// <param name="array">�������� ������ �����</param>
    /// <returns>����� ����� ������ �����</returns>
    private int SumEvenNumbersInArray(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            if(i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    /// <summary>
    /// ����� ��������� ������� OnClick ������ "����� ������� ��������� ����� � ������"
    /// </summary>
    public void OnFirstOccurrence()
    {
        // ������ ����, ����� ����������� � �������
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"������ ������� ��������� ����� {value} � ������: {got} - {message}");

        // ������ ����, ����� �� ����������� � �������
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "��������� ������" : $"��������� �� ������, ��������� {want}";
        Debug.Log($"������ ������� ��������� ����� {value} � ������: {got} - {message}");
    }

    /// <summary>
    /// ����� ���������� ����� ������� ��������� ����� � ������
    /// </summary>
    /// <param name="array">�������� ������</param>
    /// <param name="value">������� �����</param>
    /// <returns>������ �������� ����� � ������� ��� -1 ���� ����� ����������</returns>
    private int FirstOccurrence(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value) return i;
        }
        return -1;
    }

    /// <summary>
    /// ����� ��������� ������� OnClick ������ "���������� �������"
    /// </summary>
    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("�������� ������ {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("��������� ���������� {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "��������� ������" : "��������� �� ������");
    }

    /// <summary>
    /// ����� ��������� ������ ������� ������
    /// </summary>
    /// <param name="array">�������� ������</param>
    /// <returns>��������������� ������</returns>
    private int[] SelectionSort(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[i])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
}
