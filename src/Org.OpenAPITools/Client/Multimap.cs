/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList Co.,Ltd. All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// A dictionary in which one key has many associated values.
    /// </summary>
    /// <typeparam name="TKey">The type of the key</typeparam>
    /// <typeparam name="TValue">The type of the value associated with the key.</typeparam>
    public class Multimap<TKey, TValue> : IDictionary<TKey, IList<TValue>>
    {
        #region Private Fields

        private readonly Dictionary<TKey, IList<TValue>> _dictionary;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Multimap()
        {
            _dictionary = new Dictionary<TKey, IList<TValue>>();
        }

        /// <summary>
        /// Constructor with comparer.
        /// </summary>
        /// <param name="comparer"></param>
        public Multimap(IEqualityComparer<TKey> comparer)
        {
            _dictionary = new Dictionary<TKey, IList<TValue>>(comparer);
        }

        #endregion Constructors

        #region Enumerators

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<KeyValuePair<TKey, IList<TValue>>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        #endregion Enumerators

        #region Public Members
        /// <summary>
        /// Add values to Multimap
        /// </summary>
        /// <param name="item">Key value pair</param>
        public void Add(KeyValuePair<TKey, IList<TValue>> item)
        {
            if (!TryAdd(item.Key, item.Value))
                throw new InvalidOperationException("Could not add values to Multimap.");
        }

        /// <summary>
        /// Add Multimap to Multimap
        /// </summary>
        /// <param name="multimap">Multimap</param>
        public void Add(Multimap<TKey, TValue> multimap)
        {
            foreach (var item in multimap)
            {
                if (!TryAdd(item.Key, item.Value))
                    throw new InvalidOperationException("Could not add values to Multimap.");
            }
        }

        /// <summary>
        /// Clear Multimap
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
        }

        /// <summary>
        /// Determines whether Multimap contains the specified item.
        /// </summary>
        /// <param name="item">Key value pair</param>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        /// <returns>true if the Multimap contains the item; otherwise, false.</returns>
        public bool Contains(KeyValuePair<TKey, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Copy items of the Multimap to an array,
        ///     starting at a particular array index.
        /// </summary>
        /// <param name="array">The array that is the destination of the items copied
        ///     from Multimap. The array must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        public void CopyTo(KeyValuePair<TKey, IList<TValue>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified item from the Multimap.
        /// </summary>
        /// <param name="item">Key value pair</param>
        /// <returns>true if the item is successfully removed; otherwise, false.</returns>
        /// <exception cref="NotImplementedException">Method needs to be implemented</exception>
        public bool Remove(KeyValuePair<TKey, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of items contained in the Multimap.
        /// </summary>
        public int Count => _dictionary.Count;

        /// <summary>
        /// Gets a value indicating whether the Multimap is read-only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds an item with the provided key and value to the Multimap.
        /// </summary>
        /// <param name="key">The object to use as the key of the item to add.</param>
        /// <param name="value">The object to use as the value of the item to add.</param>
        /// <exception cref="InvalidOperationException">Thrown when couldn't add the value to Multimap.</exception>
        public void Add(TKey key, IList<TValue> value)
        {
            if (value != null && value.Count > 0)
            {
                if (_dictionary.TryGetValue(key, out var list))
                {
                    foreach (var k in value) list.Add(k);
                }
                else
                {
                    list = new List<TValue>(value);
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add values to Multimap.");
                }
            }
        }

        /// <summary>
        /// Determines whether the Multimap contains an item with the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the Multimap.</param>
        /// <returns>true if the Multimap contains an item with
        ///     the key; otherwise, false.</returns>
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        /// <summary>
        /// Removes item with the specified key from the Multimap.
        /// </summary>
        /// <param name="key">The key to locate in the Multimap.</param>
        /// <returns>true if the item is successfully removed; otherwise, false.</returns>
        public bool Remove(TKey key)
        {
            return TryRemove(key, out var _);
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">When this method returns, the value associated with the specified key, if the
        ///     key is found; otherwise, the default value for the type of the value parameter.
        ///     This parameter is passed uninitialized.</param>
        /// <returns> true if the object that implements Multimap contains
        ///     an item with the specified key; otherwise, false.</returns>
        public bool TryGetValue(TKey key, out IList<TValue> value)
        {
            return _dictionary.TryGetValue(key, out value);
        }

        /// <summary>
        /// Gets or sets the item with the specified key.
        /// </summary>
        /// <param name="key">The key of the item to get or set.</param>
        /// <returns>The value of the specified key.</returns>
        public IList<TValue> this[TKey key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        /// <summary>
        /// Gets a System.Collections.Generic.ICollection containing the keys of the Multimap.
        /// </summary>
        public ICollection<TKey> Keys => _dictionary.Keys;

        /// <summary>
        /// Gets a System.Collections.Generic.ICollection containing the values of the Multimap.
        /// </summary>
        public ICollection<IList<TValue>> Values => _dictionary.Values;

        /// <summary>
        ///  Copy the items of the Multimap to an System.Array,
        ///     starting at a particular System.Array index.
        /// </summary>
        /// <param name="array">The one-dimensional System.Array that is the destination of the items copied
        ///     from Multimap. The System.Array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in array at which copying begins.</param>
        public void CopyTo(Array array, int index)
        {
            ((ICollection)_dictionary).CopyTo(array, index);
        }

        /// <summary>
        /// Adds an item with the provided key and value to the Multimap.
        /// </summary>
        /// <param name="key">The object to use as the key of the item to add.</param>
        /// <param name="value">The object to use as the value of the item to add.</param>
        /// <exception cref="InvalidOperationException">Thrown when couldn't add value to Multimap.</exception>
        public void Add(TKey key, TValue value)
        {
            if (value != null)
            {
                if (_dictionary.TryGetValue(key, out var list))
                {
                    list.Add(value);
                }
                else
                {
                    list = new List<TValue> { value };
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add value to Multimap.");
                }
            }
        }

        #endregion Public Members

        #region Private Members

        /**
         * Helper method to encapsulate generator differences between dictionary types.
         */
        private bool TryRemove(TKey key, out IList<TValue> value)
        {
            _dictionary.TryGetValue(key, out value);
            return _dictionary.Remove(key);
        }

        /**
         * Helper method to encapsulate generator differences between dictionary types.
         */
        private bool TryAdd(TKey key, IList<TValue> value)
        {
            try
            {
                _dictionary.Add(key, value);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
        #endregion Private Members
    }
}
