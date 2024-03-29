﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MWU.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("1 ou mais falhas de validação ocorreram.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
