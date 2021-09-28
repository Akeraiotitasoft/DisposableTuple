using System;

namespace Akeraiotitasoft.DisposableTuple
{
    public class DisposableTuple<T1> : IDisposable
    {
        public DisposableTuple(T1 item1)
        {
            _tuple = new Tuple<T1>(item1);
        }

        public DisposableTuple(Tuple<T1> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1> _tuple;

        public Tuple<T1> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1> disposableTuple = obj as DisposableTuple<T1>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }

        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2)
        {
            _tuple = new Tuple<T1, T2>(item1, item2);
        }

        public DisposableTuple(Tuple<T1,T2> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2> _tuple;

        public Tuple<T1, T2> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2> disposableTuple = obj as DisposableTuple<T1, T2>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }

        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3)
        {
            _tuple = new Tuple<T1, T2, T3>(item1, item2, item3);
        }

        public DisposableTuple(Tuple<T1, T2, T3> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2, T3> _tuple;

        public Tuple<T1, T2, T3> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3> disposableTuple = obj as DisposableTuple<T1, T2, T3>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }


        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3, T4> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            _tuple = new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        public DisposableTuple(Tuple<T1, T2, T3, T4> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }


        private Tuple<T1, T2, T3, T4> _tuple;


        public Tuple<T1, T2, T3, T4> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;
        public T4 Item4 => _tuple.Item4;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3, T4> disposableTuple = obj as DisposableTuple<T1, T2, T3, T4>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }


        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
            (_tuple.Item4 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3, T4, T5> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            _tuple = new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        public DisposableTuple(Tuple<T1, T2, T3, T4, T5> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2, T3, T4, T5> _tuple;

        public Tuple<T1, T2, T3, T4, T5> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;
        public T4 Item4 => _tuple.Item4;
        public T5 Item5 => _tuple.Item5;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3, T4, T5> disposableTuple = obj as DisposableTuple<T1, T2, T3, T4, T5>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }


        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
            (_tuple.Item4 as IDisposable)?.Dispose();
            (_tuple.Item5 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3, T4, T5, T6> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            _tuple = new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        public DisposableTuple(Tuple<T1, T2, T3, T4, T5, T6> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2, T3, T4, T5, T6> _tuple;

        public Tuple<T1, T2, T3, T4, T5, T6> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;
        public T4 Item4 => _tuple.Item4;
        public T5 Item5 => _tuple.Item5;
        public T6 Item6 => _tuple.Item6;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3, T4, T5, T6> disposableTuple = obj as DisposableTuple<T1, T2, T3, T4, T5, T6>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }



        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
            (_tuple.Item4 as IDisposable)?.Dispose();
            (_tuple.Item5 as IDisposable)?.Dispose();
            (_tuple.Item6 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3, T4, T5, T6, T7> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            _tuple = new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        public DisposableTuple(Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2, T3, T4, T5, T6, T7> _tuple;

        public Tuple<T1, T2, T3, T4, T5, T6, T7> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;
        public T4 Item4 => _tuple.Item4;
        public T5 Item5 => _tuple.Item5;
        public T6 Item6 => _tuple.Item6;
        public T7 Item7 => _tuple.Item7;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3, T4, T5, T6, T7> disposableTuple = obj as DisposableTuple<T1, T2, T3, T4, T5, T6, T7>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }


        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
            (_tuple.Item4 as IDisposable)?.Dispose();
            (_tuple.Item5 as IDisposable)?.Dispose();
            (_tuple.Item6 as IDisposable)?.Dispose();
            (_tuple.Item7 as IDisposable)?.Dispose();
        }
    }

    public class DisposableTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IDisposable
    {
        public DisposableTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
        {
            _tuple = new Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>(item1, item2, item3, item4, item5, item6, item7, rest);
        }

        public DisposableTuple(Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple)
        {
            _tuple = tuple ?? throw new ArgumentNullException(nameof(tuple), $"{nameof(tuple)} cannot be null");
        }

        private Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> _tuple;

        public Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Tuple => _tuple;
        public T1 Item1 => _tuple.Item1;
        public T2 Item2 => _tuple.Item2;
        public T3 Item3 => _tuple.Item3;
        public T4 Item4 => _tuple.Item4;
        public T5 Item5 => _tuple.Item5;
        public T6 Item6 => _tuple.Item6;
        public T7 Item7 => _tuple.Item7;
        public TRest Rest => _tuple.Rest;

        public override bool Equals(object obj)
        {
            DisposableTuple<T1, T2, T3, T4, T5, T6, T7, TRest> disposableTuple = obj as DisposableTuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
            if (disposableTuple != null)
            {
                return _tuple.Equals(disposableTuple.Tuple);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _tuple.GetHashCode();
        }

        public override string ToString()
        {
            return _tuple.ToString();
        }

        public void Dispose()
        {
            (_tuple.Item1 as IDisposable)?.Dispose();
            (_tuple.Item2 as IDisposable)?.Dispose();
            (_tuple.Item3 as IDisposable)?.Dispose();
            (_tuple.Item4 as IDisposable)?.Dispose();
            (_tuple.Item5 as IDisposable)?.Dispose();
            (_tuple.Item6 as IDisposable)?.Dispose();
            (_tuple.Item7 as IDisposable)?.Dispose();
            (_tuple.Rest as IDisposable)?.Dispose();
        }
    }
}
