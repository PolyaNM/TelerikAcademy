namespace ClassGenericList
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
    private T[] array;
    private int count;

    public GenericList(int size)
    {
        this.array = new T[size];
        this.count = 0;
    }

    public T this[int count]
    {
        get
        {      
            return this.array[count];
        }

        set
        {
            this.array[count] = value;
        }
    }

    public void ExpandArray()
    {
        T[] tempArray = new T[array.Length * 2];
        Array.Copy(array, 0, tempArray, 0, array.Length);
        array = tempArray;
    }

    public void AddElements(T element)
    {
        if (count < array.Length)
        {
            array[count] = element;
            count++;
        }
        else
        {
            ExpandArray();
            array[count] = element;
            count++;
        }
    }

    public T AccesElement(int index)
    {
        if (index <= count)
        {
            return array[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid Index!");
        }
    }

    public void DeleteElement(int index)
    {
        if (index <= count)
        {
            T[] tempArr = new T[array.Length];
            int tempArrindex = 0;
            for (int fromBegToIndex = 0; fromBegToIndex < index; fromBegToIndex++, tempArrindex++)
            {
                tempArr[tempArrindex] = array[fromBegToIndex];
            }
 
            for (int toTheEnd = index + 1; toTheEnd < count; toTheEnd++, tempArrindex++) 
            {
                tempArr[tempArrindex] = array[toTheEnd];
            }

            Array.Copy(tempArr, 0, array, 0, array.Length);
            array = tempArr;
            count--;
        }
        else
        {
            throw new IndexOutOfRangeException("InvalidIndex!");
        }
    }

    public void InsertElement(int index, T element)
    {
        T[] tempArray = new T[array.Length];
        int tempArrayIndex = 0;
        if (count + 1 < array.Length)
        {
            for (int i = 0; i < index; i++, tempArrayIndex++)
            {
                tempArray[tempArrayIndex] = array[i];
            }

            tempArray[tempArrayIndex] = element;
            tempArrayIndex++;
            count++;

            for (int toTheEnd = index; toTheEnd < count; toTheEnd++, tempArrayIndex++)
            {
                tempArray[tempArrayIndex] = array[toTheEnd];
            }

            Array.Copy(tempArray, 0, array, 0, array.Length);
            array = tempArray;
        }
        else
        {
            ExpandArray();
            InsertElement(index, element);
        }
    }

    public void ClearArr()
    {
        for (int i = 0; i < count; )
        {
            DeleteElement(i);
        }
    }

    public int FindIndexByElement(T element)
    {
        int index = Array.IndexOf(array, element);
        return index;
    }

    public override string ToString()
    {
        StringBuilder allElements = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            allElements.AppendFormat("{0} is the {1} element of the array", array[i].ToString(), i + 1);
            allElements.AppendLine();
        }

        string final = allElements.ToString();
        return final;
    }

    public T Max<T>() where T : IComparable<T>, IComparable
    {
        dynamic max = array[0];

        for (int i = 0; i < count; i++)
        {
            T tempValue = (dynamic)this.array[i];
            if (tempValue.CompareTo(max) > 0)
            {
                max = array[i];
            }
        }

        return max;
    }

    public T Min<T>() where T : IComparable<T>, IComparable
    {
        dynamic min = array[0];

        for (int i = 0; i < count; i++)
        {
            T tempValue = (dynamic)this.array[i];
            if (tempValue.CompareTo(min) < 0)
            {
                min = array[i];
            }
        }

        return min;
    }
    }
}
